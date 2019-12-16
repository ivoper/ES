using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	public partial class FormEmitirParecerTecnico : Vista<EmitirParecerTecnicoArgs>
	{
		public FormEmitirParecerTecnico()
		{
			InitializeComponent();
		}

		private void FormEmitirParecerTecnico_Load(object sender, EventArgs e)
		{

		}

		private void emitir_Click(object sender, EventArgs e)
		{
			EmitirParecerTecnicoArgs despachoArgs = new EmitirParecerTecnicoArgs(textoLivre.Text, decisao.GetItemText(decisao.SelectedItem));
			Notificavel.Notificar(despachoArgs);
		}
	}
}
