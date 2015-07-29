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
        string tipoLista;

        public Combobox(Identificador Id, string SelectValue,string TipoLista = "option")
            : base(Id)
        {
            selectValue = SelectValue;
            tipoLista = TipoLista;
        }  
        public override void Funcao(IWebDriver pagina)
        {

            IWebElement elemento = GetElemento(pagina);
            IList<IWebElement> AllDropDownList = elemento.FindElements(By.TagName(tipoLista));
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
