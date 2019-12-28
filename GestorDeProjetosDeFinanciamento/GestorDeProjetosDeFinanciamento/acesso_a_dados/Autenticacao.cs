using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class Autenticacao
    {

        private static Autenticacao servico;

        private Autenticacao()
        {

        }

        public Utilizador FazerLogin(String username, String password)
        {
            using (Entidades context = new Entidades())
			{
                List<Utilizador> utilizadores = context.Utilizador
                    .Where(u => u.username == username && u.passw == password)
                    .Include(uti => uti.Tecnico)
                    .Include(uti => uti.GestorDeFinanciamento)
                    .Include(uti => uti.ComissaoDeFinanciamento)
                    .ToList();

                if (!utilizadores.Any())
                    return null;

                return utilizadores.First();
			}

		}

        public static Autenticacao ObterInstancia()
        {
            if (servico == null)
                servico = new Autenticacao();

            return servico;
        }

    }
}
