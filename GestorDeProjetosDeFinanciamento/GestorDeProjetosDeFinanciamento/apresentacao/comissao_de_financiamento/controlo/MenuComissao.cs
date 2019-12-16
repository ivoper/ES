using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class MenuComissao : Apresentador<FormMenuComissao, StringArgs>
	{
		public MenuComissao(ComissaoDeFinanciamento comissao) : base(new FormMenuComissao())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(StringArgs args)
		{
			//TODO ta testado pelo duduzan :c
			switch (args.texto)
			{
				case "realizarDespacho":
					new RealizarDespacho();
					break;
				case "decidirAprovacao":
					//new ListarProjetos();
					break;
				case "suspenderProjeto":
					new SuspenderProjeto();
					break;
				case "reativarProjeto":
					new ReativarProjeto();
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
