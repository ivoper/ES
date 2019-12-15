using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
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
					Console.WriteLine(1);
					break;
				case "decidirAprovacao":
					Console.WriteLine(2);
					break;
				case "suspenderProjeto":
					Console.WriteLine(3);
					break;
				case "reativarProjeto":
					Console.WriteLine(4);
					break;
				default:
					Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
					break;
			}
		}
	}
}
