using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao;
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
            Login login = new Login();
			/*using(ESEntidades context = new ESEntidades())
			{
				context.Promotor.Add(new Promotor
					{
						designacao = "boas",
						nacionalidade = "tuga",
						nif = 123456789
					}
				);
				context.SaveChanges();
			}*/
		}

	}
}
