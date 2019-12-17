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

        public AprovacaoReforco(Projeto projetoSelecionado) : base(new FormAprovacaoReforco())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoHistorico = CRUDHistorico.ObterInstancia();
            projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();

		}

		public override void Notificar(StringArgs args)
		{
			Historico historico = new Historico();
			historico.id_projeto = projeto.id;
			historico = servicoHistorico.LerHistorico(historico);
			String novoEstado;
			switch (args.texto)
			{
				case "sim":
					novoEstado = Utils.EstadoParaString(MaquinaDeEstados.processar(Utils.StringParaEstado(projeto.estado), EventosProjeto.despacho_aprovado));
					projeto.estado = Enum.GetName(typeof(EstadosProjeto), novoEstado);
                    servicoProjetos.AtualizarProjeto(projeto);
					break;
				case "nao":
                    EstadosProjeto estadoRecente = MaquinaDeEstados.processar(Utils.StringParaEstado(projeto.estado), EventosProjeto.despacho_rejeitado);
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