using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
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
using static GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo.Erro;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
    public partial class FormDeErro : Vista<StringArgs>
    {

        public FormDeErro()
        {
            InitializeComponent();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            Notificavel.Notificar(new StringArgs(copiar.Name));
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Notificavel.Notificar(new StringArgs(fechar.Name));
        }

        public void AlterarMensagemDeErro(String mensagemErro)
        {
            mensagemDeErro.Text = mensagemErro;
        }

		private void mensagemDeErro_Click(object sender, EventArgs e)
		{

		}
	}
}
