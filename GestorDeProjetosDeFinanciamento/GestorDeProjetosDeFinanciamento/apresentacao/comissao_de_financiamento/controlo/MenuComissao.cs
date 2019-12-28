using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
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

        private ComissaoDeFinanciamento comissao;

        public MenuComissao(ComissaoDeFinanciamento comissao) : base(new FormMenuComissao())
		{
            this.comissao = comissao;
			Vista.Notificavel = this;
            Vista.AlterarNome(comissao.Utilizador.username);
			Vista.ShowDialog();
		}

		public override void Notificar(StringArgs args)
		{
			//TODO ta testado pelo duduzan :c
			switch (args.texto)
			{
				case "realizarDespacho":
					new RealizarDespachoListarProjetos();
					break;
				case "decidirAprovacao":
					new AprovacaoReforcoListarProjetos();
					break;
				case "suspenderProjeto":
					new SuspenderProjeto(comissao.Utilizador);
					break;
				case "reativarProjeto":
					new ReativarProjeto(comissao.Utilizador);
					break;
				case "despachoAbertura":
					new DespachoDeAbertura();
					break;
				case "alterarDados":
					new AlterarDadosListarProjetos(comissao.Utilizador);
					break;
                case "consulta":
                    new ConsultarListarProjetos(comissao.Utilizador);
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
