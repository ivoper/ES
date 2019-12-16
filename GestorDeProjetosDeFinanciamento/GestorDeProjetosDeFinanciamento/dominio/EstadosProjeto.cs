using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    enum EstadosProjeto
    {			  //quem tem acesso -> ação -> novo estado
        aberto,   //comissao -> despacho de abertura -> analise_tecnica
        analise_tecnica, //gestor -> emite parecer -> arquivado / espera_despacho
        espera_despacho, //comissao -> emite daspacho -> rejeitado / pagamento 
        pagamento, //gestor -> pagamento -> pagamento/fechado
        suspenso, //quem o tiver
        arquivado, //tecnico -> reequandrar -> aberto
		rejeitado, //apenas consulta
        fechado //apenas consulta
    }
}
