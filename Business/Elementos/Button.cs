using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using DTO;


namespace Business.Elementos
{
    public class Button : IElemento
    {

        public Button(Identificador Id)
            : base(Id)
        {
        }  
        public override void Funcao(IWebDriver pagina)
        {
            try
            {
                IWebElement button = GetElemento(pagina);
                button.Click();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
