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
	public partial class FormAprovacaoReforco : Vista<StringArgs>
	{
		public FormAprovacaoReforco()
		{
			InitializeComponent();
		}

		private void sim_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(sim.Name));
		}

		private void nao_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new StringArgs(nao.Name));
		}

		private void FormAprovacaoReforco_Load(object sender, EventArgs e)
		{

		}
	}
}
