using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Instalacoes: IPagina
    {
        BtnsEvolucao fabricaRobots;
        BtnsEvolucao hangar;
        BtnsEvolucao labratorioPesquisas;
        BtnsEvolucao depositoAlianca;
        BtnsEvolucao fabricaNanites;
        BtnsEvolucao terraFormador;
        BtnsEvolucao siloMisseis;
        public Instalacoes()
            : base("MenuInstalacoes")
        {
            fabricaRobots = new BtnsEvolucao("FabricaRobots");
            hangar = new BtnsEvolucao("Hangar");
            labratorioPesquisas = new BtnsEvolucao("LabratorioPesquisas");
            depositoAlianca = new BtnsEvolucao("DepositoAlianca");
            fabricaNanites = new BtnsEvolucao("FabricaNanites");
            terraFormador = new BtnsEvolucao("TerraFormador");
            siloMisseis = new BtnsEvolucao("SiloMisseis");
        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }


        public void EvoluirFabricaRobots(IWebDriver pagina)
        {
            fabricaRobots.evoluir.Funcao(pagina);
        }
        public void EvoluirHangar(IWebDriver pagina)
        {
            hangar.evoluir.Funcao(pagina);
        }
        public void EvoluirLabratorioPesquisas(IWebDriver pagina)
        {
            labratorioPesquisas.evoluir.Funcao(pagina);
        }
        public void EvoluirSiloMisseis(IWebDriver pagina)
        {
            siloMisseis.evoluir.Funcao(pagina);
        }
        public void EvoluirTerraFormador(IWebDriver pagina)
        {
            terraFormador.evoluir.Funcao(pagina);
        }
        public void EvoluirFabricaNanites(IWebDriver pagina)
        {
            fabricaNanites.evoluir.Funcao(pagina);
        }
        public void EvoluirDepositoAlianca(IWebDriver pagina)
        {
            depositoAlianca.evoluir.Funcao(pagina);
        }


        public void DetailFabricaRobots(IWebDriver pagina)
        {
            fabricaRobots.detail.Funcao(pagina);
        }
        public void DetailHangar(IWebDriver pagina)
        {
            hangar.detail.Funcao(pagina);
        }
        public void DetailLabratorioPesquisas(IWebDriver pagina)
        {
            labratorioPesquisas.detail.Funcao(pagina);
        }
        public void DetailDepositoAlianca(IWebDriver pagina)
        {
            depositoAlianca.detail.Funcao(pagina);
        }
        public void DetailSiloMisseis(IWebDriver pagina)
        {
            siloMisseis.detail.Funcao(pagina);
        }
        public void DetailFabricaNanites(IWebDriver pagina)
        {
            fabricaNanites.detail.Funcao(pagina);
        }
        public void DetailTerraFormador(IWebDriver pagina)
        {
            terraFormador.detail.Funcao(pagina);
        }
    }
}
