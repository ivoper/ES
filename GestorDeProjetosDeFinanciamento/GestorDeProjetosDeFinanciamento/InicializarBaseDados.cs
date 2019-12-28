using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento
{
    class InicializarBaseDados
    {

        public static void Incializar()
        {
            using (Entidades contexto = new Entidades())
            {
                List<Estado> defaultEstados = new List<Estado>();
                defaultEstados.Add(new Estado { id = 1, estado1 = Utils.EstadoParaString(EstadosProjeto.aberto) });
                defaultEstados.Add(new Estado { id = 2, estado1 = Utils.EstadoParaString(EstadosProjeto.analise_tecnica) });
                defaultEstados.Add(new Estado { id = 3, estado1 = Utils.EstadoParaString(EstadosProjeto.espera_despacho) });
                defaultEstados.Add(new Estado { id = 4, estado1 = Utils.EstadoParaString(EstadosProjeto.pagamento) });
                defaultEstados.Add(new Estado { id = 5, estado1 = Utils.EstadoParaString(EstadosProjeto.suspenso) });
                defaultEstados.Add(new Estado { id = 6, estado1 = Utils.EstadoParaString(EstadosProjeto.arquivado) });
                defaultEstados.Add(new Estado { id = 7, estado1 = Utils.EstadoParaString(EstadosProjeto.rejeitado) });
                defaultEstados.Add(new Estado { id = 8, estado1 = Utils.EstadoParaString(EstadosProjeto.fechado) });
                defaultEstados.Add(new Estado { id = 9, estado1 = Utils.EstadoParaString(EstadosProjeto.espera_reforco) });
                defaultEstados.Add(new Estado { id = 10, estado1 = Utils.EstadoParaString(EstadosProjeto.historico) });

                if (contexto.Estado.Count() != 10)
                    contexto.Estado.AddRange(defaultEstados);


                List<EstadosTecnico> defaultEstadosTecnico = new List<EstadosTecnico>();
                defaultEstadosTecnico.Add(new EstadosTecnico() { id_estado = 6 });
                defaultEstadosTecnico.Add(new EstadosTecnico() { id_estado = 7 });

                if (contexto.EstadosTecnico.Count() != 2)
                    contexto.EstadosTecnico.AddRange(defaultEstadosTecnico);

                List<EstadosComissao> defaultEstadosComissao = new List<EstadosComissao>();
                defaultEstadosComissao.Add(new EstadosComissao() { id_estado = 1 });
                defaultEstadosComissao.Add(new EstadosComissao() { id_estado = 3 });
                defaultEstadosComissao.Add(new EstadosComissao() { id_estado = 9 });
                defaultEstadosComissao.Add(new EstadosComissao() { id_estado = 5 });
                defaultEstadosComissao.Add(new EstadosComissao() { id_estado = 7 });

                if (contexto.EstadosComissao.Count() != 5)
                    contexto.EstadosComissao.AddRange(defaultEstadosComissao);

                List<EstadosGestor> defaultEstadosGestor = new List<EstadosGestor>();
                defaultEstadosGestor.Add(new EstadosGestor() { id_estado = 2 });
                defaultEstadosGestor.Add(new EstadosGestor() { id_estado = 4 });
                defaultEstadosGestor.Add(new EstadosGestor() { id_estado = 8 });
                defaultEstadosGestor.Add(new EstadosGestor() { id_estado = 5 });
                defaultEstadosGestor.Add(new EstadosGestor() { id_estado = 7 });

                if (contexto.EstadosGestor.Count() != 5)
                    contexto.EstadosGestor.AddRange(defaultEstadosGestor);
                
                contexto.SaveChanges();
            }
        }

    }
}
