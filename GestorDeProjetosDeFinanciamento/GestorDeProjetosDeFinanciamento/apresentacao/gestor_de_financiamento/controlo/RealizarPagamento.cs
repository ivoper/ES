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

        public RealizarPagamento(Projeto projeto) : base(new FormRealizarPagamento())
		{
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoPagamento = CRUDPagamento.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(StringArgs args)
		{
            if (!VerificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários com o formato pretendido.");
                return;
            }

            double montantePago = Double.Parse(args.texto);
            double pago = servicoPagamento
                .ObterPagamentosDeProjeto(projeto)
                .Select(p => p.valor)
                .Sum();
            pago += montantePago;
            Despacho despachoMaisRecente = servicoDespacho
                .LerDespachosDeProjeto(projeto)
                .OrderBy(d => d.data_despacho)
                .Last();

            Pagamento pagamento = new Pagamento()
            {
                id_projeto = projeto.id,
                id_despacho = despachoMaisRecente.id,
                data = DateTime.Now,
                valor = montantePago
            };
            servicoPagamento.RealizarPagamento(pagamento);

            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            EstadosProjeto estadoAntigo = Utils.StringParaEstado(estado);
            EstadosProjeto estadoNovo;

            if (despachoMaisRecente.DespachoIncentivo.montante < pago)
            {
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.pagamento_completo);
                double excesso = pago - despachoMaisRecente.DespachoIncentivo.montante;
                Vista.MostraMensagemDeTexto("Foi pago em excesso, cerca de " + excesso + "." );
            }
            else if (despachoMaisRecente.DespachoIncentivo.montante == pago)
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
