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
	class RealizarDespachoListarProjetos : ListarProjetos
	{
		private readonly EstadosProjeto estado = EstadosProjeto.espera_despacho;

		public RealizarDespachoListarProjetos()
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
			Projeto projeto = projetos[args.valor - 1];
			Vista.Hide();
			Vista.Close();
			RealizarDespacho erro = new RealizarDespacho(projeto);
		}
	}
}
