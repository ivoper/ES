using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
	class MaquinaDeEstados
	{
        private static Dictionary<EstadosProjeto, Dictionary<EventosProjeto, EstadosProjeto>> maquinaDeEstados;

        static MaquinaDeEstados()
		{
            maquinaDeEstados = new Dictionary<EstadosProjeto, Dictionary<EventosProjeto, EstadosProjeto>>();
            initMaquinaDeEstados();
		}

        private static void initMaquinaDeEstados()
        {
            Dictionary<EventosProjeto, EstadosProjeto> estados_aberto = new Dictionary<EventosProjeto, EstadosProjeto>();
            estados_aberto.Add(EventosProjeto.despacho_aprovado, EstadosProjeto.analise_tecnica);
            estados_aberto.Add(EventosProjeto.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.aberto, estados_aberto);

            Dictionary<EventosProjeto, EstadosProjeto> estados_analise_tecnica = new Dictionary<EventosProjeto, EstadosProjeto>();
            estados_analise_tecnica.Add(EventosProjeto.parecer_favoravel, EstadosProjeto.espera_despacho);
            estados_analise_tecnica.Add(EventosProjeto.parecer_desfavoravel, EstadosProjeto.arquivado);
            estados_analise_tecnica.Add(EventosProjeto.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.analise_tecnica, estados_analise_tecnica);

            Dictionary<EventosProjeto, EstadosProjeto> estados_espera_despacho = new Dictionary<EventosProjeto, EstadosProjeto>();
			estados_espera_despacho.Add(EventosProjeto.despacho_aprovado, EstadosProjeto.pagamento);
			estados_espera_despacho.Add(EventosProjeto.despacho_rejeitado, EstadosProjeto.rejeitado);
			estados_espera_despacho.Add(EventosProjeto.suspender, EstadosProjeto.suspenso);
            estados_espera_despacho.Add(EventosProjeto.bonificacao, EstadosProjeto.fechado);
            maquinaDeEstados.Add(EstadosProjeto.espera_despacho, estados_espera_despacho);

            Dictionary<EventosProjeto, EstadosProjeto> estados_pagamento = new Dictionary<EventosProjeto, EstadosProjeto>();
			estados_pagamento.Add(EventosProjeto.pagamento, EstadosProjeto.pagamento);
			estados_pagamento.Add(EventosProjeto.pagamento_completo, EstadosProjeto.fechado);
			estados_pagamento.Add(EventosProjeto.suspender, EstadosProjeto.suspenso);
            estados_pagamento.Add(EventosProjeto.pedir_reforco, EstadosProjeto.espera_reforco);
            maquinaDeEstados.Add(EstadosProjeto.pagamento, estados_pagamento);

            Dictionary<EventosProjeto, EstadosProjeto> estados_suspenso = new Dictionary<EventosProjeto, EstadosProjeto>();
            estados_suspenso.Add(EventosProjeto.reativar, EstadosProjeto.historico);
            maquinaDeEstados.Add(EstadosProjeto.suspenso, estados_suspenso);

			Dictionary<EventosProjeto, EstadosProjeto> espera_reforco = new Dictionary<EventosProjeto, EstadosProjeto>();
			espera_reforco.Add(EventosProjeto.despacho_aprovado, EstadosProjeto.pagamento);
			espera_reforco.Add(EventosProjeto.despacho_rejeitado, EstadosProjeto.historico);
			maquinaDeEstados.Add(EstadosProjeto.espera_reforco, espera_reforco);

            Dictionary<EventosProjeto, EstadosProjeto> fechado = new Dictionary<EventosProjeto, EstadosProjeto>();
            fechado.Add(EventosProjeto.pedir_reforco, EstadosProjeto.espera_reforco);
            maquinaDeEstados.Add(EstadosProjeto.fechado, fechado);

            Dictionary<EventosProjeto, EstadosProjeto> arquivado = new Dictionary<EventosProjeto, EstadosProjeto>();
            arquivado.Add(EventosProjeto.reenquadrar, EstadosProjeto.aberto);
            maquinaDeEstados.Add(EstadosProjeto.arquivado, arquivado);

        }

        public static EstadosProjeto processar(EstadosProjeto estado, EventosProjeto evento)
        {
            return maquinaDeEstados[estado][evento];
        }
	}
}
