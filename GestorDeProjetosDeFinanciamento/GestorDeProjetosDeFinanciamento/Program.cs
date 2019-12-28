﻿using GestorDeProjetosDeFinanciamento.apresentacao;
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
			InicializarBaseDados.Incializar();
			Login login = new Login();
		}

	}
}
