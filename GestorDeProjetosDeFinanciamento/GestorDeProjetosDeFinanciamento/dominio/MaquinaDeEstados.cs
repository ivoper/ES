using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.dominio
{
	class MaquinaDeEstados
	{
		public Dictionary<string, Tuple<string, string>> tou;
		public MaquinaDeEstados()
		{
			tou = new Dictionary<string, Tuple<string, string>>();
			tou.Add("reenquadrado", new Tuple<string,string>("reenquadrar", "aberto"));

		}

		public EstadosProjeto processar(string estado,string acao)
		{
			
		}
	}
}
