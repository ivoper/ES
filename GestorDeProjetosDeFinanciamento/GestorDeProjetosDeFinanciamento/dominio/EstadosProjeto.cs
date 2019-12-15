using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    enum EstadosProjeto
    {
        aberto,
        analise_tecnica,
        espera_despacho,
        pagamento,
        suspenso,
        arquivado,
		rejeitado,
        fechado
    }
}
