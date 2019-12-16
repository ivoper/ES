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
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(Enum.GetName(typeof(EstadosProjeto), estado));
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];
			Vista.Hide();
			Vista.Close();
			new RealizarDespacho(projeto);
		}
	}
}
