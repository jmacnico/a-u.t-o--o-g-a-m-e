using Business.Configs;
using Business.Elementos;
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
        public Planetas(BtnsPlanetas btnSelecionar, string Nome, Coordenadas Coordenadas)
        {
            nome = Nome;
            coordenadas = Coordenadas;
            BtnSelecionar = btnSelecionar;
        }
        public static List<Planetas> GetPlanetas(IWebDriver Pagina)
        {
            List<Planetas> lstPlanetas = new List<Planetas>();
            var planetas = Pagina.FindElements(By.XPath(CustomConfig.Settings.Buttons["listaPlanetas"].Value));

            foreach (IWebElement planeta in planetas)
            {
                string IdDiv = CustomConfig.Settings.Buttons["planeta"].Value;
                IdDiv = IdDiv.Replace("?", planeta.GetAttribute("id"));
                var links = planeta.FindElements(By.TagName("a"));
                IWebElement link = links.FirstOrDefault(x => x.GetAttribute("class").Contains("planetlink"));
                string[] coorednadas = link.FindElement(By.ClassName("planet-koords")).Text.Replace("[", "").Replace("]", "").Split(':');
                lstPlanetas.Add(new Planetas(new BtnsPlanetas(new Button(new Identificador(IdDiv,ElementoPesquisaEnum._path)),null), link.FindElement(By.ClassName("planet-name")).Text, new Coordenadas(Convert.ToInt32(coorednadas[0]), Convert.ToInt32(coorednadas[1]), Convert.ToInt32(coorednadas[2]))));
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
        public Elementos.Button principal { get; set; }
        public Elementos.Button secundario { get; set; }
        public BtnsPlanetas(Elementos.Button Principal, Elementos.Button Secundario)
        {
            principal = Principal;
            secundario = Secundario;
        }
    }
}
