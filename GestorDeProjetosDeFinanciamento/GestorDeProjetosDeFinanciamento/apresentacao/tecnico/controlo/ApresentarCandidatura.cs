using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
	class ApresentarCandidatura : Apresentador<FormApresentarCandidatura, ApresentarCandidaturaArgs>
	{
		private CRUDProjetos servicoProjetos;
        private CRUDResponsavel servicoResponsavel;
        private GeradorIdsProjeto servicoIdsProjeto;
        private CRUDPromotor servicoPromotor;
        private ObterEstados servicoObterEstados;
        private Tecnico tecnico;

		public ApresentarCandidatura(Tecnico tecnico) : base(new FormApresentarCandidatura())
		{
            this.tecnico = tecnico;
			servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoResponsavel = CRUDResponsavel.ObterInstancia();
            servicoPromotor = CRUDPromotor.ObterInstancia();
            servicoIdsProjeto = GeradorIdsProjeto.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
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

            Responsavel responsavelGuardado = servicoResponsavel.LerResponsavel(args.telefone, args.email, args.designacaoResponsavel);
            int idResponsavel;
            if (responsavelGuardado == null)
            {
                servicoResponsavel.CriarResponsavel(new Responsavel()
                {
                    nome = args.designacaoResponsavel,
                    email = args.email,
                    telefone = args.telefone
                });
                idResponsavel = servicoResponsavel.LerResponsavel(args.telefone, args.email, args.designacaoResponsavel).id;
            }
            else
                idResponsavel = responsavelGuardado.id;

			decimal nibNum = Convert.ToDecimal(args.NIB);
			decimal nifNum = Convert.ToDecimal(args.NIF);
			Promotor promotorGuardado = servicoPromotor.LerPromotor(nifNum);
            int idPromotor;
            if (promotorGuardado == null)
            {
                servicoPromotor.CriarPromotor(new Promotor()
                {
                    nome = args.designacaoPromotor,
                    nacionalidade = args.nacionalidade,
                    nib = nibNum,
                    nif = nifNum
                });
                idPromotor = servicoPromotor.LerPromotor(nifNum).id;
            }
            else
                idPromotor = promotorGuardado.id;

            int idProjeto = servicoIdsProjeto.GerarIdProjeto();
            Projeto projeto = new Projeto
            {
                id = idProjeto,
                montante_solicitado = Convert.ToDouble(args.montante),
                descricao = args.descricao,
                estado = servicoObterEstados.ObterIdEstado(Utils.EstadoParaString(EstadosProjeto.aberto)),
                data_criacao = DateTime.Now,
                id_tecnico = tecnico.id_utilizador,
                id_responsavel = idResponsavel,
                id_promotor = idPromotor
            };
            
            servicoProjetos.CriarProjeto(projeto);
            if (args.tipo.ToLower().Equals("bonificação"))
                servicoProjetos.CriarBonificacao(projeto);

            else if (args.tipo.ToLower().Equals("incentivo"))
                servicoProjetos.CriarIncentivo(projeto);

			Vista.Hide();
			Vista.Close();
		}

        public bool verificarArgumentos(ApresentarCandidaturaArgs args)
        {
            double montante;
            decimal nif, nib;

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
                args.NIB.Length == 9 &&
                args.NIF.Length == 9 &&
                Double.TryParse(args.montante, out montante) &&
                Decimal.TryParse(args.NIF, out nif) &&
                Decimal.TryParse(args.NIB, out nib);
        }

    }
}
