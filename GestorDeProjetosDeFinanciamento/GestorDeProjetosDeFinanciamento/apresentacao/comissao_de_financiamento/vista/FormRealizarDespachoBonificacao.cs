using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo.args;
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
    public partial class FormRealizarDespachoBonificacao : Vista<RealizarDespachoArgs>
    {
        public FormRealizarDespachoBonificacao()
        {
            InitializeComponent();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            RealizarDespachoArgs realizarDespachoArgs = new RealizarDespachoArgs(montante_maximo.Text, taxa.Text, data.SelectionRange.Start.ToShortDateString());
            Notificavel.Notificar(realizarDespachoArgs);
        }
    }
}
