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


        public void EntrarRecursos(IWebDriver pagina, bool OpenSettings = false)
        {
            if (OpenSettings)
                recursos.settings.Entrar(pagina);
            else
                recursos.principal.Entrar(pagina);
        }
        public void EntrarVistaGeral(IWebDriver pagina)
        {
            vistaGeral.principal.Entrar(pagina);
        }
        public void EntrarInstalacoes(IWebDriver pagina)
        {
            instalacoes.principal.Entrar(pagina);
        }
        public void EntrarPesquisas(IWebDriver pagina, bool OpenSettings = false)
        {
            if (OpenSettings)
                pesquisas.settings.Entrar(pagina);
            else
                pesquisas.principal.Entrar(pagina);
        }
        public void EntrarHangar(IWebDriver pagina)
        {
            hangar.principal.Entrar(pagina);
        }
        public void EntrarDefesas(IWebDriver pagina)
        {
            defesas.principal.Entrar(pagina);
        }
        public void EntrarGalaxia(IWebDriver pagina)
        {
            galaxia.principal.Entrar(pagina);
        }
        public void EntrarFrota(IWebDriver pagina, bool OpenSettings = false)
        {
            if (OpenSettings)
                frota.settings.Entrar(pagina);
            else
                frota.principal.Entrar(pagina);
        }
    }
}
