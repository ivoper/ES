using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    enum Evento
    {
        despacho_de_abertura,
        parecer_favoravel,
        parecer_desfavoravel,
        despacho_aprovado,
        despacho_rejeitado,
        pagamento,
        pagamento_completo,
        reenquadrar,
        suspender,
        reativar
    }
}
