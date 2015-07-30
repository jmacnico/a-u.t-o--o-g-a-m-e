using Business.Elementos;
using Business.Paginas;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Menu
{
    public class Menu
    {
        public MenuPaginas recursos { get; private set; }
        public MenuPaginas vistaGeral { get; private set; }
        public MenuPaginas instalacoes { get; private set; }
        public MenuPaginas pesquisas{ get; private set; }
        public MenuPaginas hangar { get; private set; }
        public MenuPaginas frota { get; private set; }
        public MenuPaginas defesas { get; private set; }
        public MenuPaginas galaxia { get; private set; }

        public Menu()
        {
            recursos = new MenuPaginas(new Recursos(), new RecursosSettings());
            vistaGeral = new MenuPaginas(new VistaGeral(), null);
            instalacoes = new MenuPaginas(new Instalacoes(), null);
            pesquisas = new MenuPaginas(new Pesquisas(), new PesquisaSettings());
            hangar = new MenuPaginas(new Hangar(), null);
            frota = new MenuPaginas(new Frota(), new FrotaSettings());
            defesas = new MenuPaginas(new Defesas(), null);
            galaxia = new MenuPaginas(new Galaxia(), null);
        }
        
    }
}
