using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    class Utils
    {
        public static EstadosProjeto StringParaEstado(string estadoS)
        {
            EstadosProjeto estado;
            Enum.TryParse(estadoS, out estado);
            return estado;
        }

        public static string EstadoParaString(EstadosProjeto estado)
        {
            return Enum.GetName(typeof(EstadosProjeto), estado);
        }
    }
}
