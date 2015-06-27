using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class Combobox : IElemento
    {
        public string selectValue { get; private set; }

        public Combobox(string Id, ElementoPesquisaEnum elemTipoPesquisa, string SelectValue)
            : base(Id,elemTipoPesquisa)
        {
            selectValue = SelectValue;
        }  
        public override void Funcao(IWebDriver pagina)
        {

            IWebElement elemento = GetElemento(pagina);
            IList<IWebElement> AllDropDownList = elemento.FindElements(By.TagName("option"));
            foreach (var item in AllDropDownList)
            {
                if (item.Text.ToUpper() == selectValue.ToUpper())
                {

                    item.Click();
                    item.SendKeys(Keys.Enter);
                    break;
                }
            }
        }
    }
}
