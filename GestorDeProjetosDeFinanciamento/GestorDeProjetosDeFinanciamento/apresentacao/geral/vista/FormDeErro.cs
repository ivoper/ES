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
using static GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo.Erro;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
    public partial class FormDeErro : Form
    {

        public event CopiarClick OnCopiarClick;
        public event FecharClick OnFecharClick;

        public FormDeErro()
        {
            InitializeComponent();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            OnCopiarClick(this, null);
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            OnFecharClick(this, null);
        }

        public void AlterarMensagemDeErro(String mensagemErro)
        {
            mensagemDeErro.Text = mensagemErro;
        }
    }
}
