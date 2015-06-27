using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class BtnMenu : Button
    {
        public string textName;

        public BtnMenu(string id, ElementoPesquisaEnum pesquisa,string TextName) : base (id,pesquisa)
        {
            textName = TextName;       
        }
        public override OpenQA.Selenium.IWebElement GetElemento(OpenQA.Selenium.IWebDriver pagina)
        {
            try
            {
                switch (tipoPesquisa)
                {
                    case ElementoPesquisaEnum._id:
                        IWebElement menu = pagina.FindElement(By.Id("menuTable"));
                        var lstli = menu.FindElements(By.TagName("li"));
                        var li = lstli.FirstOrDefault(x => x.Text == id);
                        return li.FindElements(By.TagName("a")).FirstOrDefault(x => x.Text == textName);
                        
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
