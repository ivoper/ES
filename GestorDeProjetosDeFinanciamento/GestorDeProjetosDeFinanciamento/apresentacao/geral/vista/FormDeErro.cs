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
    public partial class FormDeErro : Vista<SimplesArgs>
    {

        public FormDeErro()
        {
            InitializeComponent();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            Notificavel.Notificar(new SimplesArgs(copiar.Name));
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Notificavel.Notificar(new SimplesArgs(fechar.Name));
        }

        public void AlterarMensagemDeErro(String mensagemErro)
        {
            mensagemDeErro.Text = mensagemErro;
        }
    }
}
