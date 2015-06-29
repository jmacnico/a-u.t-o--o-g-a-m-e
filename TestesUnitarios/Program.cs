using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using Business;
using System.Configuration;
using Business.Menu;
using Business.Elementos;
using Business.Paginas;
using System.Xml;
using System.IO;


namespace TestesUnitarios
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Utilizador utilizador = new Utilizador(ConfigurationSettings.AppSettings["Username"].ToString(), ConfigurationSettings.AppSettings["Password"].ToString(), ConfigurationSettings.AppSettings["Universo"].ToString());
            Login login = new Login(utilizador);
            login.OpenPagina();
            login.Entrar(login.paginaElementos);
            login.global.listPlanetas[0].Selecionar(login.paginaElementos);
            //Menu menu = new Menu();
            //menu.Recursos.principal.Entrar(NegocioGeral.PaginaElementos);
            //Recursos recurso = new Recursos();
            //recurso.EvoluirMinaMetal(NegocioGeral.PaginaElementos);
            //menu.Recursos.settings.Entrar(NegocioGeral.PaginaElementos);
            //menu.VistaGeral.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Pesquisas.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Pesquisas.settings.Entrar(NegocioGeral.PaginaElementos);
            //menu.Hangar.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Defesas.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Frota.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Frota.settings.Entrar(NegocioGeral.PaginaElementos);
            //menu.Instalacoes.principal.Entrar(NegocioGeral.PaginaElementos);
            //menu.Galaxia.principal.Entrar(NegocioGeral.PaginaElementos);
        }
    }
}
