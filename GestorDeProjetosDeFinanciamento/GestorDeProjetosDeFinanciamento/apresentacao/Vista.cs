using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    public class Vista<A> : Form
    {
        internal Notificavel<A> Notificavel { get; set; }
    }
}
