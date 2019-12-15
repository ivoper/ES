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
	public partial class FormMenuGestor : Vista<StringArgs>
	{
		public FormMenuGestor()
		{
			InitializeComponent();
		}

		private void emitirParecer_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(emitirParecer.Name));
		}

		private void realizarPagamento_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(realizarPagamento.Name));
		}

		private void alterarDados_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(alterarDados.Name));
		}

		private void pedirReforco_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(pedirReforco.Name));
		}

		private void reativarProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(reativarProjeto.Name));
		}

		private void suspenderProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(suspenderProjeto.Name));
		}

		private void FormMenuGestor_Load(object sender, EventArgs e)
		{

		}

		private void logout_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(logout.Name));
		}
	}
}
