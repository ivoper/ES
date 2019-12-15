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
	public partial class FormMenuComissao : Vista<SimplesArgs>
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
			Notificavel.Notificar(new SimplesArgs(realizarDespacho.Name));
		}

		private void decidirAprovacao_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new SimplesArgs(decidirAprovacao.Name));
		}

		private void suspenderProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new SimplesArgs(suspenderProjeto.Name));
		}

		private void reativarProjeto_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new SimplesArgs(reativarProjeto.Name));
		}
	}
}
