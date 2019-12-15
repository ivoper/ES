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
	public partial class FormListarProjetos : Vista<SimplesArgs>
	{


		public FormListarProjetos()
		{
			InitializeComponent();
		}

		private void FormListarProjetos_Load(object sender, EventArgs e)
		{

		}

        private void confirmar_Click(object sender, EventArgs e)
        {
			SimplesArgs loginArgs = new SimplesArgs("");
			Notificavel.Notificar(loginArgs);
		}

        private void projetos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
