using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
    class EmitirParecerTecnicoListarProjetos : ListarProjetos
    {

        private readonly EstadosProjeto estado = EstadosProjeto.analise_tecnica;

        public EmitirParecerTecnicoListarProjetos()
        {
            servicoProjetos = CRUDProjetos.ObterInstancia();
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstado(Enum.GetName(typeof(EstadosProjeto), estado));
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
            Projeto projeto = projetos[args.valor];
            Vista.Hide();
            Vista.Close();
            EmitirParecerTecnico emitirParecerTecnico = new EmitirParecerTecnico(projeto);
        }
    }
}
