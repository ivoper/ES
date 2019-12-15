using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class Projetos : Apresentador<FormListarProjetos, SimplesArgs>
	{

		public Projetos() : base(new FormListarProjetos())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(SimplesArgs args)
		{

		}

	}
}