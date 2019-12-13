using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    public class Apresentador<V> where V : Form
    {

        private V vista;

        public Apresentador(V vista)
        {
            this.vista = vista;
        }

        public V Vista
        {
            get => vista;
            set => vista = value;
        }

    }
}
