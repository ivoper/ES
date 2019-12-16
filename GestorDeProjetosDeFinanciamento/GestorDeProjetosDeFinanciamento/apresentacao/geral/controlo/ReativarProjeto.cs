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
		private EstadosProjeto estado = EstadosProjeto.suspenso;       //só vai ter um

		public ReativarProjeto(User user)
		{
            string estadoString = Enum.GetName(typeof(EstadosProjeto), estado);   //passa de Estados para string
            Vista.Notificavel = this;
            projetos.Add(servicoProjetos.ProjetosComHistorico(estadoString));
            listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			if (args.valor == 0) return;
			Projeto projeto = projetos[args.valor];
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
