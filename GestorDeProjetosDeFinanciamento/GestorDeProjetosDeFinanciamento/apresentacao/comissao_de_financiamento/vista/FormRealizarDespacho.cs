using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
	public partial class FormRealizarDespacho : Vista<DespachoArgs>
	{
		public FormRealizarDespacho()
		{
			InitializeComponent();
		}

		private void FormRealizarDespacho_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void realizar_Click(object sender, EventArgs e)
		{
			DespachoArgs despachoArgs = new DespachoArgs(resultado.GetItemText(resultado.SelectedItem),custoElegivel.Text,montante.Text, prazo.SelectionRange.Start.ToShortDateString());
			Notificavel.Notificar(despachoArgs);
		}
	}
}
