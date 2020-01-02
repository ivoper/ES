using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
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
	public partial class FormRealizarDespacho : Vista<StringArgs>
	{
		public FormRealizarDespacho()
		{
			InitializeComponent();
		}

		private void FormRealizarDespacho_Load(object sender, EventArgs e)
		{

		}

		private void realizar_Click(object sender, EventArgs e)
		{
			StringArgs stringArgs = new StringArgs(resultado.GetItemText(resultado.SelectedItem));
			Notificavel.Notificar(stringArgs);
		}

		public void adicionarListBox()
		{
			resultado.Items.Add("Transformado em Bonificação");
		}
	}
}
