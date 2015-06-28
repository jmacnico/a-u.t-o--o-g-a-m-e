using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Recursos : IPagina
    {
        Elementos.BtnRecusros MinaMetal;
        Elementos.BtnRecusros MinaMetalFast;
        Elementos.BtnRecusros MinaCristal;
        Elementos.BtnRecusros MinaCristalFast;
        Elementos.BtnRecusros MinaDeuterio;
        Elementos.BtnRecusros MinaDeuterioFast;
        Elementos.BtnRecusros PlantaEnergia;
        Elementos.BtnRecusros PlantaEnergiaFast;
        Elementos.BtnRecusros PlantaFusao;
        Elementos.BtnRecusros PlantaFusaoFast;
       
        public Recursos() :base(new Elementos.BtnMenu("Recursos",Elementos.ElementoPesquisaEnum._id,"Recursos"))
        {
            MinaMetal = new Elementos.BtnRecusros("button1", Elementos.ElementoPesquisaEnum._id, "details", "building");
            MinaMetalFast = new Elementos.BtnRecusros("button1", Elementos.ElementoPesquisaEnum._id, "", "building");
            MinaCristal = new Elementos.BtnRecusros("button2", Elementos.ElementoPesquisaEnum._id, "details", "building");
            MinaCristalFast = new Elementos.BtnRecusros("button2", Elementos.ElementoPesquisaEnum._id, "", "building");
            MinaDeuterio = new Elementos.BtnRecusros("button3", Elementos.ElementoPesquisaEnum._id, "details", "building");
            MinaDeuterioFast = new Elementos.BtnRecusros("button3", Elementos.ElementoPesquisaEnum._id, "", "building");
            PlantaEnergia = new Elementos.BtnRecusros("button4", Elementos.ElementoPesquisaEnum._id, "details", "building");
            PlantaEnergiaFast = new Elementos.BtnRecusros("button4", Elementos.ElementoPesquisaEnum._id, "", "building");
            PlantaFusao = new Elementos.BtnRecusros("button5", Elementos.ElementoPesquisaEnum._id, "details", "building");
            PlantaFusaoFast = new Elementos.BtnRecusros("button5", Elementos.ElementoPesquisaEnum._id, "", "building");
        }
        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }

        public void EvoluirMinaMetal(IWebDriver pagina)
        {
            MinaMetal.Funcao(pagina);
        }
    }
}
