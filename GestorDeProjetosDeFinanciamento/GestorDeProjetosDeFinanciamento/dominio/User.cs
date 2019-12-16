using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
    class User
    {
        public User()
        {

        }

        public int id { get; set; }
        public string username { get; set; }
        public List<EstadosProjeto> estadosValidos { get;  }
    }
}
