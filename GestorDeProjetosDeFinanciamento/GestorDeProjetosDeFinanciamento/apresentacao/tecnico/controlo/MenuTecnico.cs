﻿using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class MenuTecnico : Apresentador<FormMenuTecnico, StringArgs>
    {
        public MenuTecnico(Tecnico tecnico): base(new FormMenuTecnico())
        {
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
					new SuspenderProjeto();
					break;
                case "reativarProjeto":
					new ReativarProjeto();
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