using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class CRUDParecerTecnico
    {
        private static CRUDParecerTecnico servico;

        private CRUDParecerTecnico()
        {

        }

        public List<ParecerTecnico> LerParecerTecnicosDeProjeto(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.ParecerTecnico.Where(d => d.id_projeto == projeto.id).ToList();
            }
        }

        public void CriarParecerTecnico(ParecerTecnico parecerTecnico)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.ParecerTecnico.Add(new ParecerTecnico()
                {
                    texto = parecerTecnico.texto,
                    decisao = parecerTecnico.decisao,
                    id_projeto = parecerTecnico.id_projeto,
                    data_parecer = parecerTecnico.data_parecer
                });
                contexto.SaveChanges();
            }
        }

        public static CRUDParecerTecnico ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDParecerTecnico();

            return servico;
        }
    }
}
