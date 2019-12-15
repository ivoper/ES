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
	public partial class FormRealizarPagamento : Vista<RealizarPagamentoArgs>
	{
		public FormRealizarPagamento()
		{
			InitializeComponent();
		}

		private void pagar_Click(object sender, EventArgs e)
		{
			RealizarPagamentoArgs despachoArgs = new RealizarPagamentoArgs(montante.Text);
			Notificavel.Notificar(despachoArgs);
		}

		private void FormRealizarPagamento_Load(object sender, EventArgs e)
		{
	
		}
	}
}
