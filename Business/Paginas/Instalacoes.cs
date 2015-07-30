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
        public BtnsEvolucao FabricaRobots { get; private set; }
        public BtnsEvolucao Hangar { get; private set; }
        public BtnsEvolucao LabratorioPesquisas { get; private set; }
        public BtnsEvolucao DepositoAlianca { get; private set; }
        public BtnsEvolucao FabricaNanites { get; private set; }
        public BtnsEvolucao TerraFormador { get; private set; }
        public BtnsEvolucao SiloMisseis { get; private set; }
        public Instalacoes()
            : base("MenuInstalacoes")
        {
            FabricaRobots = new BtnsEvolucao("FabricaRobots");
            Hangar = new BtnsEvolucao("Hangar");
            LabratorioPesquisas = new BtnsEvolucao("LabratorioPesquisas");
            DepositoAlianca = new BtnsEvolucao("DepositoAlianca");
            FabricaNanites = new BtnsEvolucao("FabricaNanites");
            TerraFormador = new BtnsEvolucao("TerraFormador");
            SiloMisseis = new BtnsEvolucao("SiloMisseis");
        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }



    }
}
