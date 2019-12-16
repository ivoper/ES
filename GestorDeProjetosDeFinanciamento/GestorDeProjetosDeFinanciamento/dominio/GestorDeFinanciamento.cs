using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    class GestorDeFinanciamento : User
    {
        public GestorDeFinanciamento()
        {
            estadosValidos.Add(EstadosProjeto.analise_tecnica);
            estadosValidos.Add(EstadosProjeto.pagamento);
            estadosValidos.Add(EstadosProjeto.fechado);
            estadosValidos.Add(EstadosProjeto.suspenso);
            estadosValidos.Add(EstadosProjeto.rejeitado);
        }
    }
}
