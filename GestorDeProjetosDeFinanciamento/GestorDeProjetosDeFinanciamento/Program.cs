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
            //Login login = new Login();
			using(EntidadesBaseDeDados context = new EntidadesBaseDeDados())
			{
				context.Promotor.Add(new Promotor
					{
						designacao = "boas",
						nacionalidade = "tuga",
						nif = 2
					}
				);
				
				Promotor aux = context.Promotor.Find(1);
				Console.WriteLine(aux.designacao);
				context.SaveChanges();
			}
		}

	}
}
