using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class MenuGestor : Apresentador<FormMenuGestor, StringArgs>
	{

        private GestorDeFinanciamento gestor;

        public MenuGestor(GestorDeFinanciamento gestor) : base(new FormMenuGestor())
		{
            this.gestor = gestor;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}


		public override void Notificar(StringArgs args)
		{
			//TODO fully testado pelo duduzan e ta bom :)
			switch (args.texto)
			{
				case "emitirParecer":
					new EmitirParecerTecnicoListarProjetos();
					break;
				case "realizarPagamento":
					new RealizarPagamentoListarProjeto();
					break;
				case "alterarDados":
					Console.WriteLine("alterar dados");
					break;
				case "suspenderProjeto":
					new SuspenderProjeto(gestor);
					break;
				case "reativarProjeto":
					new ReativarProjeto(gestor);
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
