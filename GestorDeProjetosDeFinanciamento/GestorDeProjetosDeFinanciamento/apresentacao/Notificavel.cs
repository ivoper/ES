using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    public interface Notificavel<A> where A : EventArgs
    {
        void Notificar(A args);
    }
}
