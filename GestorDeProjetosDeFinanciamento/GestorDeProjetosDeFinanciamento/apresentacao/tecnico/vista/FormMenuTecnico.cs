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
using static GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo.MenuTecnico;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista
{
    public partial class FormMenuTecnico : Vista<SimplesArgs>
    {

        public FormMenuTecnico()
        {
            InitializeComponent();
        }

        private void FormMenuTecnico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeBotao = apresentarCandidatura.Name;
            Notificavel.Notificar(new SimplesArgs(nomeBotao));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeBotao = reenquadrarProjeto.Name;
            Notificavel.Notificar(new SimplesArgs(nomeBotao));
        }

        private void suspenderProjeto_Click(object sender, EventArgs e)
        {
            string nomeBotao = suspenderProjeto.Name;
            Notificavel.Notificar(new SimplesArgs(nomeBotao));
        }

        private void reativarProjeto_Click(object sender, EventArgs e)
        {
            string nomeBotao = reativarProjeto.Name;
            Notificavel.Notificar(new SimplesArgs(nomeBotao));
        }

    }
}
