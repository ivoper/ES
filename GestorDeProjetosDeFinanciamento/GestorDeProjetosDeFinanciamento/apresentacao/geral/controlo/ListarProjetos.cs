using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class ListarProjetos : Apresentador<FormListarProjetos, SimplesArgs>
	{

		public ListarProjetos() : base(new FormListarProjetos())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(SimplesArgs args)
		{
			Console.WriteLine("Ainda temos q pensar nesta form");
			Vista.Hide();
			Vista.Close();
		}

	}
}