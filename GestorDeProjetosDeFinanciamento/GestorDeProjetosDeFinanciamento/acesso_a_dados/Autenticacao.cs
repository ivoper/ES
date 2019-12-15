using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				return context.Utilizador.SingleOrDefault(utilizador => utilizador.username == username && utilizador.passw == password);
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
