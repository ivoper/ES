using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class ReativarProjeto : ListarProjetos
	{
		private readonly EstadosProjeto estado = EstadosProjeto.suspenso;   

		public ReativarProjeto()
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(Enum.GetName(typeof(EstadosProjeto),estado));
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			if (args.valor == 0) return;
			Projeto projeto = projetos[args.valor - 1];
			Historico historico = new Historico();
			historico.id = projeto.id;
			historico = servicoProjetos.LerHistorico(historico);
			projeto.estado = historico.estado;
			servicoProjetos.AtualizarProjeto(projeto);
			servicoProjetos.EliminarHistorico(historico);
			Vista.Hide();
			Vista.Close();
		}
	}
}
