using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class Textbox : IElemento
    {

         
        
        public string text { get; set; }

        public Textbox(Identificador Id, string Text = "")
            : base(Id)
        {
            text = Text;
        }    
        public override void Funcao(IWebDriver pagina)
        {
            try
            {
                IWebElement textbox = GetElemento(pagina);
                textbox.SendKeys(text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
