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

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
	public partial class FormDeConfirmacao : Vista<SimplesArgs>
	{
		public FormDeConfirmacao()
		{
			InitializeComponent();
		}

		private void nao_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new SimplesArgs(nao.Name));
		}

		private void FormDeConfirmacao_Load(object sender, EventArgs e)
		{

		}

		private void sim_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new SimplesArgs(sim.Name));
		}
	}
}
