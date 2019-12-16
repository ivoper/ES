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

        public User FazerLogin(String username, String password)
        {
            Utilizador utilizador;

            using (Entidades context = new Entidades())
			{
				utilizador = context.Utilizador.SingleOrDefault(u => u.username == username && u.passw == password);
			}
            if (utilizador == null) return null;
            switch (utilizador.tipo)
            {
                case "tecnico":
                    return new Tecnico()
                    {
                        id = utilizador.id,
                        username = utilizador.username
                    };
                case "gestor de financiamento":
                    return new GestorDeFinanciamento()
                    {
                        id = utilizador.id,
                        username = utilizador.username
                    };
                case "comissao de financiamento":
                    return new ComissaoDeFinanciamento()
                    {
                        id = utilizador.id,
                        username = utilizador.username
                    };
                default:
                    return null;
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
