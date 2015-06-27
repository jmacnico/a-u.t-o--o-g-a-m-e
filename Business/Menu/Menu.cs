using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Menu
{
    public class Menu
    {
        public string Nome { get; private set; }
        public MenuPaginas Recursos { get; private set; }
        public MenuPaginas VistaGeral { get; private set; }
        public MenuPaginas Instalacoes { get; private set; }
        public MenuPaginas Pesquisas { get; private set; }
        public MenuPaginas Hangar { get; private set; }
        public MenuPaginas Frota { get; private set; }
        public MenuPaginas Defesas { get; private set; }
        public MenuPaginas Galaxia { get; private set; }

        public Menu()
        {
            Recursos = new MenuPaginas(new Paginas.Recursos(), new Paginas.RecursosSettings());
            VistaGeral = new MenuPaginas(new Paginas.VistaGeral(), null);
            Instalacoes = new MenuPaginas(new Paginas.Instalacoes(),null);
            Pesquisas = new MenuPaginas(new Paginas.Pesquisas(), new Paginas.PesquisasSettings());
            Hangar = new MenuPaginas(new Paginas.Hangar(),null);
            Frota = new MenuPaginas(new Paginas.Frota(), new Paginas.FrotaSettings());
            Defesas = new MenuPaginas(new Paginas.Defesas(), null);
            Galaxia = new MenuPaginas(new Paginas.Galaxia(), null);
        }
    }
}
