using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
    class ReforcoFinanciamentoListarProjetos : ListarProjetos
    {
        private List<EstadosProjeto> estados = new List<EstadosProjeto>();

        public ReforcoFinanciamentoListarProjetos()
        {
            estados.Add(EstadosProjeto.fechado);
            estados.Add(EstadosProjeto.pagamento);
            IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));   //passa de Estados para string
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstado(estadosString);
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
            Vista.Hide();
            Vista.Close();
            new ReforcoDeFinanciamento(projetos[args.valor]);
        }
    }
}
