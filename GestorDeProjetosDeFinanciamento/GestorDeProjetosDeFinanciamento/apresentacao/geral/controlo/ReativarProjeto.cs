using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class ReativarProjeto : ListarProjetos
	{
		private readonly EstadosProjeto estado = EstadosProjeto.suspenso;       //só vai ter um

		public ReativarProjeto(User user)
		{
            string estadoString = Enum.GetName(typeof(EstadosProjeto), estado);   //passa de Estados para string
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosComHistorico(estadoString).ToList();
            IEnumerable<string> estadosString = user.estadosValidos.Select(e => Enum.GetName(typeof(EstadosProjeto), e));   //passa de Estados para string
            projetos = projetos.Where(p => estadosString.Contains(p.estado)).ToList();
            listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];     //projeto com id e estado para pôr
            Projeto aux = servicoProjetos.LerProjeto(projeto);  //projeto que tem todos os detalhes
            aux.estado = projeto.estado;                        //atualizar estado
			servicoProjetos.AtualizarProjeto(aux);
            Historico historico = new Historico()
            {
                id_projeto = projeto.id
            };
            servicoHistorico.EliminarHistorico(historico);
			Vista.Hide();
			Vista.Close();
		}
	}
}
