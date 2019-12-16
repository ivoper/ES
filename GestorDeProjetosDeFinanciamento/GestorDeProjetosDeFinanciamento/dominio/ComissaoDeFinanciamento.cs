using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    class ComissaoDeFinanciamento : User
    {
        public ComissaoDeFinanciamento()
        {
            estadosValidos.Add(EstadosProjeto.aberto);
            estadosValidos.Add(EstadosProjeto.espera_despacho);
            estadosValidos.Add(EstadosProjeto.espera_reforco);
            estadosValidos.Add(EstadosProjeto.suspenso);
            estadosValidos.Add(EstadosProjeto.rejeitado);
        }
    }
}
