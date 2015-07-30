using Business.Configs;
using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Recursos : IPagina
    {
        public BtnsEvolucao MinaMetal { get; private set; }
        public BtnsEvolucao MinaCristal { get; private set; }
        public BtnsEvolucao MinaDeuterio { get; private set; }
        public BtnsEvolucao PlantaEnergia { get; private set; }
        public BtnsEvolucao PlantaFusao { get; private set; }
        public BtnsEvolucao ArmazemMetal { get; private set; }
        public BtnsEvolucao ArmazemCristal { get; private set; }
        public BtnsEvolucao ArmazemDeuterio { get; private set; }
        public BtnsEvolucao EsconderijoMetal { get; private set; }
        public BtnsEvolucao EsconderijoCristal { get; private set; }
        public BtnsEvolucao EsconderijoDeuterio { get; private set; }


        public Recursos()
            : base("MenuRecursos")
        {
            MinaMetal = new BtnsEvolucao("MinaMetal");
            MinaCristal = new BtnsEvolucao("MinaCristal");
            MinaDeuterio = new BtnsEvolucao("MinaDeuterio");
            PlantaEnergia = new BtnsEvolucao("PlantaEnergia");
            PlantaFusao = new BtnsEvolucao("PlantaFusao");
            ArmazemMetal = new BtnsEvolucao("ArmazemMetal");
            ArmazemCristal = new BtnsEvolucao("ArmazemCristal");
            ArmazemDeuterio = new BtnsEvolucao("ArmazemDeuterio");
            EsconderijoMetal = new BtnsEvolucao("EsconderijoMetal");
            EsconderijoCristal = new BtnsEvolucao("EsconderijoCristal");
            EsconderijoDeuterio = new BtnsEvolucao("EsconderijoDeuterio");
        }
        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
         
        //public void EvoluirMinaMetal(IWebDriver pagina)
        //{
        //    MinaMetal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirMinaCristal(IWebDriver pagina)
        //{
        //    MinaCristal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirMinaDeuterio(IWebDriver pagina)
        //{
        //    MinaDeuterio.evoluir.Funcao(pagina);
        //}
        //public void EvoluirPlantaEnergia(IWebDriver pagina)
        //{
        //    PlantaEnergia.evoluir.Funcao(pagina);
        //}
        //public void EvoluirPlantaFusao(IWebDriver pagina)
        //{
        //    PlantaFusao.evoluir.Funcao(pagina);
        //}
        //public void EvoluirArmazemMetal(IWebDriver pagina)
        //{
        //    ArmazemMetal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirArmazemCristal(IWebDriver pagina)
        //{
        //    ArmazemCristal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirArmazemDeuterio(IWebDriver pagina)
        //{
        //    ArmazemDeuterio.evoluir.Funcao(pagina);
        //}
        //public void EvoluirEsconderijoMetal(IWebDriver pagina)
        //{
        //    EsconderijoMetal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirEsconderijoCristal(IWebDriver pagina)
        //{
        //    EsconderijoCristal.evoluir.Funcao(pagina);
        //}
        //public void EvoluirEsconderijoDeuterio(IWebDriver pagina)
        //{
        //    EsconderijoDeuterio.evoluir.Funcao(pagina);
        //}



        //public void DetailMinaMetal(IWebDriver pagina)
        //{
        //    MinaMetal.detail.Funcao(pagina);
        //}
        //public void DetailMinaCristal(IWebDriver pagina)
        //{
        //    MinaCristal.detail.Funcao(pagina);
        //}
        //public void DetailMinaDeuterio(IWebDriver pagina)
        //{
        //    MinaDeuterio.detail.Funcao(pagina);
        //}
        //public void DetailPlantaEnergia(IWebDriver pagina)
        //{
        //    PlantaEnergia.detail.Funcao(pagina);
        //}
        //public void DetailPlantaFusao(IWebDriver pagina)
        //{
        //    PlantaFusao.detail.Funcao(pagina);
        //}
        //public void DetailArmazemMetal(IWebDriver pagina)
        //{
        //    ArmazemMetal.detail.Funcao(pagina);
        //}
        //public void DetailArmazemCristal(IWebDriver pagina)
        //{
        //    ArmazemCristal.detail.Funcao(pagina);
        //}
        //public void DetailArmazemDeuterio(IWebDriver pagina)
        //{
        //    ArmazemDeuterio.detail.Funcao(pagina);
        //}
        //public void DetailEsconderijoMetal(IWebDriver pagina)
        //{
        //    EsconderijoMetal.detail.Funcao(pagina);
        //}
        //public void DetailEsconderijoCristal(IWebDriver pagina)
        //{
        //    EsconderijoCristal.detail.Funcao(pagina);
        //}
        //public void DetailEsconderijoDeuterio(IWebDriver pagina)
        //{
        //    EsconderijoDeuterio.detail.Funcao(pagina);
        //}
    }
}
