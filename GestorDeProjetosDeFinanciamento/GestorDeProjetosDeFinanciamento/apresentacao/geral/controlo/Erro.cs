using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    class Erro : Apresentador<FormDeErro, EventArgs>
    {
        
        private String mensagemErro;

        public Erro(String mensagemErro) : base(new FormDeErro())
        {
            this.mensagemErro = mensagemErro;
            Vista.AlterarMensagemDeErro(mensagemErro);
            Vista.ShowDialog();
            Vista.Notificavel = this;
        }

        private void OnCopiarClick(object sender, EventArgs erroArgs)
        {
            System.Windows.Forms.Clipboard.SetText(mensagemErro);
        }

        private void OnFecharClick(object sender, EventArgs eventArgs)
        {
            Vista.Close();
        }

        public override void Notificar(EventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
