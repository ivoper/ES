using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class AprovacaoReforco : Apresentador<FormAprovacaoReforco, StringArgs>
	{
		private Projeto projeto;
		private CRUDProjetos servicoProjetos;
        private CRUDHistorico servicoHistorico;
		private ObterEstados servicoObterEstados;
		private CRUDPedidoDeReforco servicoPedidoDeReforco;
		private CRUDDespacho servicoDespacho;
		private PedidoDeReforco pedidoDeReforco;

		public AprovacaoReforco(Projeto projetoSelecionado) : base(new FormAprovacaoReforco())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoHistorico = CRUDHistorico.ObterInstancia();
			servicoObterEstados = ObterEstados.ObterInstancia();
			servicoDespacho = CRUDDespacho.ObterInstancia();
			servicoPedidoDeReforco = CRUDPedidoDeReforco.ObterInstancia();

			pedidoDeReforco = servicoPedidoDeReforco.LerPedidoDeReforcoPorDecidir(new PedidoDeReforco()
			{
				id_despacho = servicoDespacho.LerUltimoDespacho(projetoSelecionado).id
			});
			Vista.AlterarDados(pedidoDeReforco.montante.ToString(), pedidoDeReforco.prazo.ToString());
			projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(StringArgs args)
		{
			Historico historico = servicoHistorico.LerHistorico(new Historico()
			{
				id_projeto = projeto.id
			});
			String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
			switch (args.texto)
			{
				case "sim":
					pedidoDeReforco.decisao = "aprovado";
					servicoPedidoDeReforco.AtualizarPedidoDeReforco(pedidoDeReforco);

					String estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(
                        Utils.StringParaEstado(estado), 
                        EventosProjeto.despacho_aprovado));
					projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
                    servicoProjetos.AtualizarProjeto(projeto);
					break;
				case "nao":
					pedidoDeReforco.decisao = "rejeitado";
					servicoPedidoDeReforco.AtualizarPedidoDeReforco(pedidoDeReforco);

					EstadosProjeto estadoRecente = MaquinaDeEstados.processar(
                        Utils.StringParaEstado(estado),
                        EventosProjeto.despacho_rejeitado);
					if(estadoRecente == EstadosProjeto.historico)
					{
						projeto.estado = historico.estado;
                        servicoProjetos.AtualizarProjeto(projeto);
					}
					break;
			}

            servicoHistorico.EliminarHistorico(historico);
			Vista.Hide();
			Vista.Close();
		}
	}
}