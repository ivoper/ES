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
            using (Entidades contexto = new Entidades())
            {
                if (utilizador.Tecnico != null)
                    return contexto.EstadosTecnico.Select(t => contexto.Estado.Find(t.id_estado)).ToList();

                else if (utilizador.GestorDeFinanciamento != null)
                    return contexto.EstadosGestor.Select(t => contexto.Estado.Find(t.id_estado)).ToList();

                else if (utilizador.ComissaoDeFinanciamento != null)
                    return contexto.EstadosComissao.Select(t => contexto.Estado.Find(t.id_estado)).ToList();
            }

            return new List<Estado>();
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
