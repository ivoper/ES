using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	public partial class FormReforcoDeFinanciamento : Vista<ReforcoDeFinanciamentoArgs>
	{
		public FormReforcoDeFinanciamento()
		{
			InitializeComponent();
		}

		private void pedir_Click(object sender, EventArgs e)
		{
			ReforcoDeFinanciamentoArgs despachoArgs = new ReforcoDeFinanciamentoArgs(montante.Text, data.SelectionRange.Start.ToShortDateString());
			Notificavel.Notificar(despachoArgs);
		}

		private void FormReforcoDeFinanciamento_Load(object sender, EventArgs e)
		{

		}
	}
}
