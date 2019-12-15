using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class MenuComissao : Apresentador<FormMenuComissao, SimplesArgs>
	{
		public MenuComissao() : base(new FormMenuComissao())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(SimplesArgs args)
		{
			//TODO ta testado pelo duduzan :)
			switch (args.botaoClicado)
			{
				case "realizarDespacho":
					new RealizarDespacho();
					break;
				case "decidirAprovacao":
					new ListarProjetos();
					break;
				case "suspenderProjeto":
					new ListarProjetos();
					break;
				case "reativarProjeto":
					new ListarProjetos();
					break;
				case "logout":
					Vista.Hide();
					Vista.Close();
					new Login();
					break;
				default:
					Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
					break;
			}
		}
	}
}
