using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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
		private CRUDProjetos servico;

		public AprovacaoReforco(Projeto projetoSelecionado) : base(new FormAprovacaoReforco())
		{
			servico = CRUDProjetos.ObterInstancia();
			projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();

		}

		public override void Notificar(StringArgs args)
		{
			Historico historico = new Historico();
			historico.id = projeto.id;
			historico = servico.LerHistorico(historico);
			EstadosProjeto estadoAntigo;
			Enum.TryParse(projeto.estado, out estadoAntigo);
			EstadosProjeto novoEstado = MaquinaDeEstados.processar(estadoAntigo, Evento.despacho_aprovado);
			switch (args.texto)
			{
				case "sim":
					projeto.estado = Enum.GetName(typeof(EstadosProjeto), novoEstado);
					servico.AtualizarProjeto(projeto);
					break;
				case "nao":
					
					break;
			}
		}
	}
}