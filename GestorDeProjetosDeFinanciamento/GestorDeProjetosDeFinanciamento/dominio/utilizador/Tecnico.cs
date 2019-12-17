using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    class Tecnico : User
    {
        public Tecnico()
        {
            estadosValidos.Add(EstadosProjeto.arquivado);
            estadosValidos.Add(EstadosProjeto.suspenso);
            estadosValidos.Add(EstadosProjeto.rejeitado);
        }

    }
}
