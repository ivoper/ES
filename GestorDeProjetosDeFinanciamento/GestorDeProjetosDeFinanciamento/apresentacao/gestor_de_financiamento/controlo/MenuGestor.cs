using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class MenuGestor : Apresentador<FormMenuGestor, SimplesArgs>
	{
		public MenuGestor() : base(new FormMenuGestor())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}


		public override void Notificar(SimplesArgs args)
		{
			//TODO fully testado pelo duduzan e ta bom :)
			switch (args.botaoClicado)
			{
				case "emitirParecer":
					Console.WriteLine("e");
					break;
				case "realizarPagamento":
					Console.WriteLine("r");
					break;
				case "alterarDados":
					Console.WriteLine("a");
					break;
				case "suspenderProjeto":
					Console.WriteLine("s");
					break;
				case "reativarProjeto":
					Console.WriteLine("reativar");
					break;
				case "pedirReforco":
					Console.WriteLine("p");
					break;
				default:
					Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
					break;
			}
		}
	}
}
