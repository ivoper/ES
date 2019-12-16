using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
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

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	public partial class FormRealizarPagamento : Vista<StringArgs>
	{
		public FormRealizarPagamento()
		{
			InitializeComponent();
		}

		private void pagar_Click(object sender, EventArgs e)
		{
            StringArgs despachoArgs = new StringArgs(montante.Text);
			Notificavel.Notificar(despachoArgs);
		}

		private void FormRealizarPagamento_Load(object sender, EventArgs e)
		{
	
		}

        public void MostraMensagemDeTexto(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
	}
}
