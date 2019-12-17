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
			historico.id = projeto.id;
			historico = servicoHistorico.LerHistorico(historico);
			EstadosProjeto estadoAntigo;
			Enum.TryParse(projeto.estado, out estadoAntigo);
			EstadosProjeto novoEstado;
			switch (args.texto)
			{
				case "sim":
					novoEstado = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.despacho_aprovado);
					projeto.estado = Enum.GetName(typeof(EstadosProjeto), novoEstado);
                    servicoProjetos.AtualizarProjeto(projeto);
					break;
				case "nao":
					novoEstado = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.despacho_rejeitado);
					if(novoEstado == EstadosProjeto.historico)
					{
						projeto.estado = historico.estado;
                        servicoProjetos.AtualizarProjeto(projeto);
					}
					break;
			}
			Vista.Hide();
			Vista.Close();
		}
	}
}