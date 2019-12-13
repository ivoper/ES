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
    public partial class FormMenuTecnico : Vista<MenuArgs>
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
            Button button = (Button)sender;
            Notificavel.Notificar(new MenuArgs(button.Name));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Notificavel.Notificar(new MenuArgs(button.Name));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Notificavel.Notificar(new MenuArgs(button.Name));
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Notificavel.Notificar(new MenuArgs(button.Name));
        }
    }
}
