using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados.crud
{
    class ObterEstados
    {

        private static ObterEstados servico;

        private ObterEstados()
        {

        }

        public List<Estado> ObterEstadosValidos(Utilizador utilizador)
        {
            List<Estado> estados = new List<Estado>();
            
            using (Entidades contexto = new Entidades())
            {
                
                if (utilizador.Tecnico != null)
                {
                    foreach (EstadosTecnico estado in contexto.EstadosTecnico)
                        estados.Add(contexto.Estado.Find(estado.id_estado));
                }

                else if (utilizador.GestorDeFinanciamento != null)
                {
                    foreach (EstadosGestor estado in contexto.EstadosGestor)
                        estados.Add(contexto.Estado.Find(estado.id_estado));
                }
                    
                else if (utilizador.ComissaoDeFinanciamento != null)
                {
                    foreach (EstadosComissao estado in contexto.EstadosComissao)
                        estados.Add(contexto.Estado.Find(estado.id_estado));
                }
            }

            return estados;
        }

        public int ObterIdEstado(String estado)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Estado.Where(e => e.estado1.Equals(estado)).First().id;
            }
        }

        public Estado ObterEstado(int id)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Estado.Find(id);
            }
        }

        public static ObterEstados ObterInstancia()
        {
            if (servico == null)
                servico = new ObterEstados();

            return servico;
        }
    }
}
