using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class ReforcoDeFinanciamento : Apresentador<FormReforcoDeFinanciamento, ReforcoDeFinanciamentoArgs>
	{
        private Projeto projeto;
        private CRUDProjetos servicoProjetos;
        private CRUDHistorico servicoHistorico;
        protected CRUDDespacho servicoDespacho;
        private CRUDPedidoDeReforco servicoPedidoDeReforco;
        private ObterEstados servicoObterEstados;

        public ReforcoDeFinanciamento(Projeto projeto) : base(new FormReforcoDeFinanciamento())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoHistorico = CRUDHistorico.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            servicoPedidoDeReforco = CRUDPedidoDeReforco.ObterInstancia();
            this.projeto = projeto;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ReforcoDeFinanciamentoArgs args)
		{
            
            if (VerificarArgumentos(args))
            {
                new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            // Confirmacao da data do despacho de um projeto de bonificacao, se ja expirou ou nao.
            Despacho ultimoDespacho = servicoDespacho.LerUltimoDespacho(projeto);
            if (ultimoDespacho.DespachoBonificacao != null)
                ConfirmarDespachoExpirado(projeto, ultimoDespacho.DespachoBonificacao);

            servicoPedidoDeReforco.CriarPedidoDeReforco(new PedidoDeReforco()
            {
                id_despacho = ultimoDespacho.id,
                montante = Convert.ToDouble(args.montante),
                prazo = Convert.ToDateTime(args.data),
                data_pedido = DateTime.Now
            });

            Historico historico = new Historico()
            {
                id_projeto = projeto.id,
                estado = projeto.estado
            };
            servicoHistorico.CriarHistorico(historico);          //historico criado

            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            String estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(estado),
                EventosProjeto.pedir_reforco));
            projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);          //estado atualizado
            
            Vista.Hide();
			Vista.Close();
		}

        private void ConfirmarDespachoExpirado(Projeto projeto, DespachoBonificacao despachoBonificacao)
        {
            DateTime dataLimite = despachoBonificacao.periodo.GetValueOrDefault();
            if (DateTime.Compare(DateTime.Today, dataLimite) > 0)
            {
                String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
                EstadosProjeto estadoAntigo = Utils.StringParaEstado(estado);
                EstadosProjeto estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.pagamento_completo);
                String superEstadoNovo = Utils.EstadoParaString(estadoNovo);
                projeto.estado = servicoObterEstados.ObterIdEstado(superEstadoNovo);
                servicoProjetos.AtualizarProjeto(projeto);
            }
        }

        private bool VerificarArgumentos(ReforcoDeFinanciamentoArgs args)
        {
            double montante;
            DateTime data = Convert.ToDateTime(args.data);
            return !Double.TryParse(args.montante, out montante) || DateTime.Compare(data, DateTime.Now) <= 0;
        }
	}
}
