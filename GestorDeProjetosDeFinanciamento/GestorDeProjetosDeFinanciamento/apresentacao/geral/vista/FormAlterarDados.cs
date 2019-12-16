using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
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
	public partial class FormAlterarDados : Vista<AlterarDadosArgs>
	{
		public FormAlterarDados()
		{
			InitializeComponent();
		}

		private void Alterar_Click(object sender, EventArgs e)
		{
			AlterarDadosArgs alterarDados = new AlterarDadosArgs(email.Text, telefone.Text);
			Notificavel.Notificar(alterarDados);
		}

		private void FormAlterarDados_Load(object sender, EventArgs e)
		{

		}
	}
}
