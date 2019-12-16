﻿using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class MenuTecnico : Apresentador<FormMenuTecnico, StringArgs>
    {
        private Tecnico tecnico;

        public MenuTecnico(Tecnico tecnico): base(new FormMenuTecnico())
        {
            this.tecnico = tecnico;
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(StringArgs args)
        {
            switch (args.texto)
            {
                case "apresentarCandidatura":
					new ApresentarCandidatura();
                    break;
                case "reenquadrarProjeto":
					//new ListarProjetos();
					break;
                case "suspenderProjeto":
					new SuspenderProjeto(tecnico);
					break;
                case "reativarProjeto":
					new ReativarProjeto(tecnico);
					break;
				case "logout":
					Vista.Hide();
					Vista.Close();
					new Login();
					break;
				default:
                    Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
                    break;
            }
        }
    }
}