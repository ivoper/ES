using GestorDeProjetosDeFinanciamento.apresentacao;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
using System;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Login login = new Login();
			EmitirParecerTecnico d = new EmitirParecerTecnico();
		}

	}
}
