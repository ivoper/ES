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
	public partial class FormMenuComissao : Vista<StringArgs>
	{
		public FormMenuComissao()
		{
			InitializeComponent();
		}

		private void FormMenuComissao_Load(object sender, EventArgs e)
		{

		}

		private void realizarDespacho_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(realizarDespacho.Name));
		}

		private void decidirAprovacao_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(decidirAprovacao.Name));
		}

        internal void AlterarNome(string user)
        {
            username.Text = user;
        }

        private void suspenderProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(suspenderProjeto.Name));
		}

		private void reativarProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(reativarProjeto.Name));
		}

		private void logout_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(logout.Name));
		}

		private void despachoAbertura_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(despachoAbertura.Name));
		}

		private void alterarDados_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(alterarDados.Name));
		}

        private void consulta_Click(object sender, EventArgs e)
        {
            Notificavel.Notificar(new StringArgs(consulta.Name));
        }
    }
}
