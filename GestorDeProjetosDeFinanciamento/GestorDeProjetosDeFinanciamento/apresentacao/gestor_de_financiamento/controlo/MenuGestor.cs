using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
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
					new EmitirParecerTecnico();
					break;
				case "realizarPagamento":
					new RealizarPagamento();
					break;
				case "alterarDados":
					Console.WriteLine("alterar dados");
					break;
				case "suspenderProjeto":
					new ListarProjetos();
					break;
				case "reativarProjeto":
					new ListarProjetos();
					break;
				case "pedirReforco":
					new ReforcoDeFinanciamento();
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
