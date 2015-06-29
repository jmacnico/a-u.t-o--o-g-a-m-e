using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class btnPlanetas : Button
    {
        public btnPlanetas(string IdDiv, ElementoPesquisaEnum ele) : base (IdDiv,ele)
        {

        }
        public override OpenQA.Selenium.IWebElement GetElemento(OpenQA.Selenium.IWebDriver pagina)
        {
            var containerPlanetas = pagina.FindElement(By.Id("planetList"));
            var planeta = containerPlanetas.FindElement(By.Id(id));
            var links = planeta.FindElements(By.TagName("a"));
            return links.FirstOrDefault(x => x.GetAttribute("class").Contains("planetlink"));
        }
    }
}
