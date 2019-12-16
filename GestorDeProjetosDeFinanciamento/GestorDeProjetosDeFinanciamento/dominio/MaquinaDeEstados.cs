using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
	class MaquinaDeEstados
	{
        private static Dictionary<EstadosProjeto, Dictionary<Evento, EstadosProjeto>> maquinaDeEstados;

        static MaquinaDeEstados()
		{
            maquinaDeEstados = new Dictionary<EstadosProjeto, Dictionary<Evento, EstadosProjeto>>();
            initMaquinaDeEstados();
		}

        private static void initMaquinaDeEstados()
        {
            Dictionary<Evento, EstadosProjeto> estados_aberto = new Dictionary<Evento, EstadosProjeto>();
            estados_aberto.Add(Evento.despacho_aprovado, EstadosProjeto.analise_tecnica);
            estados_aberto.Add(Evento.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.aberto, estados_aberto);

            Dictionary<Evento, EstadosProjeto> estados_analise_tecnica = new Dictionary<Evento, EstadosProjeto>();
            estados_analise_tecnica.Add(Evento.parecer_favoravel, EstadosProjeto.espera_despacho);
            estados_analise_tecnica.Add(Evento.parecer_desfavoravel, EstadosProjeto.arquivado);
            estados_analise_tecnica.Add(Evento.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.analise_tecnica, estados_analise_tecnica);

            Dictionary<Evento, EstadosProjeto> estados_espera_despacho = new Dictionary<Evento, EstadosProjeto>();
			estados_espera_despacho.Add(Evento.despacho_aprovado, EstadosProjeto.pagamento);
			estados_espera_despacho.Add(Evento.despacho_rejeitado, EstadosProjeto.rejeitado);
			estados_espera_despacho.Add(Evento.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.espera_despacho, estados_espera_despacho);

            Dictionary<Evento, EstadosProjeto> estados_pagamento = new Dictionary<Evento, EstadosProjeto>();
			estados_pagamento.Add(Evento.pagamento, EstadosProjeto.pagamento);
			estados_pagamento.Add(Evento.pagamento_completo, EstadosProjeto.fechado);
			estados_pagamento.Add(Evento.suspender, EstadosProjeto.suspenso);
            maquinaDeEstados.Add(EstadosProjeto.pagamento, estados_pagamento);

            Dictionary<Evento, EstadosProjeto> estados_suspenso = new Dictionary<Evento, EstadosProjeto>();
            estados_suspenso.Add(Evento.reativar, EstadosProjeto.historico);
            maquinaDeEstados.Add(EstadosProjeto.suspenso, estados_suspenso);

			Dictionary<Evento, EstadosProjeto> espera_reforco = new Dictionary<Evento, EstadosProjeto>();
			espera_reforco.Add(Evento.despacho_aprovado, EstadosProjeto.pagamento);
			espera_reforco.Add(Evento.despacho_rejeitado, EstadosProjeto.historico);
			maquinaDeEstados.Add(EstadosProjeto.espera_reforco, estados_suspenso);
		}

        public static EstadosProjeto processar(EstadosProjeto estado, Evento evento)
        {
            return maquinaDeEstados[estado][evento];
        }

	}
}
