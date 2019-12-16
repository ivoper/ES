using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
	class ApresentarCandidatura : Apresentador<FormApresentarCandidatura, ApresentarCandidaturaArgs>
	{
		private CRUDProjetos servicoProjetos;
        private GeradorIdsProjeto servicoIdsProjeto;
        private Tecnico tecnico;

		public ApresentarCandidatura(Tecnico tecnico) : base(new FormApresentarCandidatura())
		{
            this.tecnico = tecnico;
			servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoIdsProjeto = GeradorIdsProjeto.ObterInstancia();
            Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ApresentarCandidaturaArgs args)
		{

            if (!verificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários com o formato pretendido.");
                return;
            }

            Responsavel responsavelGuardado = servicoProjetos.LerResponsavel(args.telefone, args.email, args.designacaoResponsavel);
            int idResponsavel;
            if (responsavelGuardado.id == 0)
            {
                servicoProjetos.CriarResponsavel(new Responsavel()
                {
                    designacao = args.designacaoResponsavel,
                    email = args.email,
                    telefone = args.telefone
                });
                idResponsavel = servicoProjetos.LerResponsavel(args.telefone, args.email, args.designacaoResponsavel).id;
            }
            else
                idResponsavel = responsavelGuardado.id;
            

            decimal nibNum = Convert.ToDecimal(args.NIB);
            decimal nifNum = Convert.ToDecimal(args.NIF);
            Projeto projeto = new Projeto
            {
                id = servicoIdsProjeto.GerarIdProjeto(),
                tipo = args.tipo,
                montante_financiamento = Convert.ToDouble(args.montante),
                descricao = args.descricao,
                estado = Enum.GetName(typeof(EstadosProjeto), EstadosProjeto.aberto),
                data_criacao = DateTime.Now,
                id_tecnico = tecnico.id,
                id_responsavel = idResponsavel,
                nif = nibNum
            };
            servicoProjetos.CriarProjeto(projeto);

            Promotor promotorGuardado = servicoProjetos.LerPromotor(nifNum);
            if (promotorGuardado == null)
            {
                servicoProjetos.CriarPromotor(new Promotor()
                {
                    designacao = args.designacaoPromotor,
                    nacionalidade = args.nacionalidade,
                    nib = nibNum,
                    nif = nifNum
                });
            }

			Vista.Hide();
			Vista.Close();
		}

        public bool verificarArgumentos(ApresentarCandidaturaArgs args)
        {
            double montante;
            decimal nif;

            return
                !args.descricao.Equals("") &&
                !args.designacaoPromotor.Equals("") &&
                !args.designacaoResponsavel.Equals("") &&
                !args.email.Equals("") &&
                !args.montante.Equals("") &&
                !args.nacionalidade.Equals("") &&
                !args.NIB.Equals("") &&
                !args.NIF.Equals("") &&
                !args.telefone.Equals("") &&
                !args.tipo.Equals("") &&
                Double.TryParse(args.montante, out montante) &&
                Decimal.TryParse(args.NIF, out nif);
        }

    }
}
