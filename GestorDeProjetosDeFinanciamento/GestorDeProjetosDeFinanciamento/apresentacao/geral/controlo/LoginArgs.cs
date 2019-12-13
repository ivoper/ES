using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    public class LoginArgs : EventArgs
    {
        public readonly String username;
        public readonly String password;

        public LoginArgs(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
