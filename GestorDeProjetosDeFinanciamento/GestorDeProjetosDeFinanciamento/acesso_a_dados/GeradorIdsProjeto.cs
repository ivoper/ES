using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class GeradorIdsProjeto
    {

        private static GeradorIdsProjeto servico;
        private static List<int> ids;
        private CRUDProjetos servicoProjetos;

        private GeradorIdsProjeto()
        {
            servicoProjetos = CRUDProjetos.ObterInstancia();
            ids = servicoProjetos
                .LerTodosOsProjetos()
                .Select(p => p.id)
                .ToList();
        }

        public int GerarIdProjeto()
        {
            int year = DateTime.Now.Year;
            Random rnd = new Random();
            int randomId = rnd.Next(10000, 100000);
            int id = randomId * 10000 + year;

            if (ids.Contains(id))
                return GerarIdProjeto();

            ids.Add(id);
            return id;
        }

        public static GeradorIdsProjeto ObterInstancia()
        {
            if (servico == null)
                servico = new GeradorIdsProjeto();

            return servico;
        }

    }
}
