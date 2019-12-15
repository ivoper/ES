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

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista
{
    public partial class FormApresentarCandidatura : Vista<ApresentarCandidaturaArgs>
    {
        public FormApresentarCandidatura()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void ApresentarCandidatura_Load(object sender, EventArgs e)
		{

		}

		private void apresentar_Click(object sender, EventArgs e)
		{
			Notificavel.Notificar(new ApresentarCandidaturaArgs(descricaoPromotor.Text,textBoxNacionalidade.Text,NIF.Text,NIB.Text,designacaoResponsavel.Text,email.Text,telefone.Text,montante.Text, tipoDoProjeto.GetItemText(tipoDoProjeto.SelectedItem),descricaoProjeto.Text));
		}
	}
}
