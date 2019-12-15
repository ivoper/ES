using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    class Erro : Apresentador<FormDeErro, StringArgs>
    {
        
        private String mensagemErro;

        public Erro(String mensagemErro) : base(new FormDeErro())
        {
            this.mensagemErro = mensagemErro;
            Vista.AlterarMensagemDeErro(mensagemErro);
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(StringArgs args)
        {
            switch(args.texto)
            {
                case "copiar":
                    System.Windows.Forms.Clipboard.SetText(mensagemErro);
                    break;
                case "fechar":
                    Vista.Close();
                    break;
            }
        }
    }
}
