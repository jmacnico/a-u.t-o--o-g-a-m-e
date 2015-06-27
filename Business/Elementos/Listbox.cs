using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class Listbox : IElemento
    {
        public string selectValue { get; private set; }
        public Listbox(string Id, ElementoPesquisaEnum elemTipoPesquisa, string SelectValue)
            : base(Id,elemTipoPesquisa)
        {
            selectValue = SelectValue;
        }  
        public override void Funcao(OpenQA.Selenium.IWebDriver pagina)
        {
            IWebElement elemento = GetElemento(pagina);
            IList<IWebElement> AllDropDownList = elemento.FindElements(By.TagName("li"));
            foreach (var item in AllDropDownList)
            {
                if (item.Text.ToUpper() == selectValue.ToUpper())
                {

                    item.Click();
                    break;
                }
            }
        }
    }
    public class ListElemento
    {
        public string SelectValies { get; private set; }
        public ElementoPesquisaEnum tipoProcura { get; set; }
        public String valorProcura { get; set; }

    }
}
