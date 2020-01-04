using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;

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
            String hashPassword = ObterHash(password);
            using (Entidades context = new Entidades())
			{
                List<Utilizador> utilizadores = context.Utilizador
                    .Where(u => u.username.Equals(username) && u.passw.Equals(hashPassword))
                    .Include(uti => uti.Tecnico)
                    .Include(uti => uti.GestorDeFinanciamento)
                    .Include(uti => uti.ComissaoDeFinanciamento)
                    .ToList();

                if (!utilizadores.Any())
                    return null;

                return utilizadores.First();
			}

		}

        private String ObterHash(String password)
        {
            HashAlgorithm hash = SHA256.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes =  hash.ComputeHash(passwordBytes);
            return Convert.ToBase64String(hashBytes);
        }

        public static Autenticacao ObterInstancia()
        {
            if (servico == null)
                servico = new Autenticacao();

            return servico;
        }

    }
}
