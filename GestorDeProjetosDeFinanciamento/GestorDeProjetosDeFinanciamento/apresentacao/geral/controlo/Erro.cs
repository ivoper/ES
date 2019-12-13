using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    public class Erro : Apresentador<FormDeErro>
    {

        public delegate void CopiarClick(object sender, EventArgs eventArgs);
        public delegate void FecharClick(object sender, EventArgs eventArgs);
        private String mensagemErro;

        public Erro(String mensagemErro) : base(new FormDeErro())
        {
            this.mensagemErro = mensagemErro;
            Vista.OnCopiarClick += new CopiarClick(OnCopiarClick);
            Vista.OnFecharClick += new FecharClick(OnFecharClick);
            Vista.AlterarMensagemDeErro(mensagemErro);
            Vista.ShowDialog();
        }

        private void OnCopiarClick(object sender, EventArgs erroArgs)
        {
            System.Windows.Forms.Clipboard.SetText(mensagemErro);
        }

        private void OnFecharClick(object sender, EventArgs eventArgs)
        {
            Vista.Close();
        }

    }
}
