using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class AprovacaoReforcoListarProjetos : ListarProjetos
	{
		private readonly EstadosProjeto estado = EstadosProjeto.espera_reforco;

		public AprovacaoReforcoListarProjetos()
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(Enum.GetName(typeof(EstadosProjeto), estado));
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			if (args.valor == 0) return;
			Projeto projeto = projetos[args.valor];
			Vista.Hide();
			Vista.Close();
			new AprovacaoReforco(projeto);
		}
	}
}
