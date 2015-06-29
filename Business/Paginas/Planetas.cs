using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Planetas
    {
        public string nome { get; set; }
        public Coordenadas coordenadas { get; private set; }

        BtnsPlanetas BtnSelecionar; 
        public Planetas(string IdDiv,string Nome, Coordenadas Coordenadas)
        {
            nome = Nome;
            coordenadas = Coordenadas;
            BtnSelecionar = new BtnsPlanetas(new Elementos.btnPlanetas(IdDiv,Elementos.ElementoPesquisaEnum._id),null);
        }
        public static List<Planetas> GetPlanetas(IWebDriver Pagina)
        {
            List<Planetas> lstPlanetas = new List<Planetas>();
            var containerPlanetas = Pagina.FindElement(By.Id("planetList"));
            var planetas = containerPlanetas.FindElements(By.TagName("Div"));

            foreach (IWebElement planeta in planetas)
            {
                string IdDiv = planeta.GetAttribute("id");
                var links = planeta.FindElements(By.TagName("a"));
                IWebElement link = links.FirstOrDefault(x => x.GetAttribute("class").Contains("planetlink"));
                string[] coorednadas = link.FindElement(By.ClassName("planet-koords")).Text.Replace("[", "").Replace("]", "").Split(':');
                lstPlanetas.Add(new Planetas(IdDiv, link.FindElement(By.ClassName("planet-name")).Text, new Coordenadas(Convert.ToInt32(coorednadas[0]), Convert.ToInt32(coorednadas[1]), Convert.ToInt32(coorednadas[2]))));
            }
            return lstPlanetas;
        }

        public bool Selecionar(IWebDriver pagina)
        {
            BtnSelecionar.principal.Funcao(pagina);
            
            return true;
        }
    }

    public class Coordenadas
    {
        public int galaxia { get; private set; }
        public int sistemaSolar { get; private set; }
        public int posicao { get; private set; }
        public Coordenadas(int Galaxia,int SistemaSolar, int Posicao)
        {
            posicao = Posicao;
            galaxia = Galaxia;
            sistemaSolar = SistemaSolar;
        }
    }

    public class BtnsPlanetas
    {
        public Elementos.btnPlanetas principal { get; set; }
        public Elementos.btnPlanetas secundario { get; set; }
        public BtnsPlanetas(Elementos.btnPlanetas Principal, Elementos.btnPlanetas Secundario)
        {
            principal = Principal;
            secundario = Secundario;
        }
    }
}
