using System;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    abstract class Apresentador<V, A> : Notificavel<A> where V : Form where A : EventArgs
    {
        public Apresentador(V vista)
        {
            Vista = vista;
        }

        public V Vista { get; set; }

        public abstract void Notificar(A args);
    }
}
