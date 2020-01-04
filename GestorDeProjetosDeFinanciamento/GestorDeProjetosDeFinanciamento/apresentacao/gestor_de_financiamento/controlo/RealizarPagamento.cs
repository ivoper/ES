using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class RealizarPagamento : Apresentador<FormRealizarPagamento, StringArgs>
	{

        protected CRUDProjetos servicoProjetos;
        protected CRUDDespacho servicoDespacho;
        private CRUDPagamento servicoPagamento;
        private ObterEstados servicoObterEstados;
        private Projeto projeto;
        private Despacho despacho;
        private DespachoIncentivo despachoMaisRecente;

        public RealizarPagamento(Projeto projeto) : base(new FormRealizarPagamento())
		{
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoPagamento = CRUDPagamento.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            despacho = servicoDespacho.LerUltimoDespacho(projeto);
            despachoMaisRecente = despacho.DespachoIncentivo;
            bool expirou = ConfirmarData();
            Vista.Notificavel = this;
			Vista.ShowDialog();
            if (expirou)
            {
                Erro erro = new Erro("A data de pagamento do projeto expirou.");
                Vista.Hide();
                Vista.Close();
            }
		}

        private bool ConfirmarData()
        {
            IEnumerable<PedidoDeReforco> pedidosDeReforco = despacho.PedidoDeReforco;
            DateTime dataParaComparar;

            if (pedidosDeReforco.Any())
                dataParaComparar = pedidosDeReforco.OrderBy(p => p.data_pedido).Last().data_pedido;
            else
                dataParaComparar = despachoMaisRecente.prazo_execucao.GetValueOrDefault();

           return DateTime.Compare(dataParaComparar, DateTime.Now) <= 0;
        }

		public override void Notificar(StringArgs args)
		{
            if (!VerificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários com o formato pretendido.");
                return;
            }

            double montantePago = Double.Parse(args.texto);
            despacho = servicoDespacho.LerUltimoDespacho(projeto);
            despachoMaisRecente = despacho.DespachoIncentivo;
            double totalAPagar = despachoMaisRecente.montante.GetValueOrDefault();

            foreach (PedidoDeReforco pedidoDeReforco in despacho.PedidoDeReforco)
                if (pedidoDeReforco.decisao.Equals("aprovado"))
                    totalAPagar += pedidoDeReforco.montante;

            double pago = servicoPagamento
                .ObterPagamentosDeProjeto(projeto)
                .Where(p => p.id_despacho == despachoMaisRecente.id_despacho)
                .Select(p => p.valor)
                .Sum();
            pago += montantePago;

            Pagamento pagamento = new Pagamento()
            {
                id_projeto = projeto.id,
                id_despacho = despachoMaisRecente.Despacho.id,
                data = DateTime.Now,
                valor = montantePago
            };
            servicoPagamento.RealizarPagamento(pagamento);

            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            EstadosProjeto estadoAntigo = Utils.StringParaEstado(estado);
            EstadosProjeto estadoNovo;

            if (totalAPagar < pago)
            {
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.pagamento_completo);
                double excesso = pago - despachoMaisRecente.montante.GetValueOrDefault();
                Vista.MostraMensagemDeTexto("Foi pago em excesso, cerca de " + excesso + "€ (Euros) .");
            }
            else if (totalAPagar == pago)
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.pagamento_completo);
            else
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.pagamento);

            String superEstadoNovo = Utils.EstadoParaString(estadoNovo);

            projeto.estado = servicoObterEstados.ObterIdEstado(superEstadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);

            Vista.Hide();
			Vista.Close();
		}

        private bool VerificarArgumentos(StringArgs m)
        {
            Double montante;
            return !m.texto.Equals("") && Double.TryParse(m.texto, out montante);
        }

    }
}
