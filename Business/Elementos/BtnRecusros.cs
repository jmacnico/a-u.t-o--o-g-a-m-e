using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    class BtnRecusros : Button
    {
        string listName;
        string textName;

        public BtnRecusros(string id, ElementoPesquisaEnum pesquisa, string TextName, string ListName)
            : base(id, pesquisa)
        {
            textName = TextName;
            listName = ListName;
        }

        public override IWebElement GetElemento(IWebDriver pagina)
        {
            try
            {
                switch (tipoPesquisa)
                {
                    case ElementoPesquisaEnum._id:
                        IWebElement Buttons = pagina.FindElement(By.Id("buttonz"));
                        IWebElement Content = Buttons.FindElement(By.ClassName("content"));
                        IWebElement ul = pagina.FindElement(By.Id(listName));
                        IWebElement li = ul.FindElement(By.Id(id));
                        var a = li.FindElements(By.TagName("a"));

                        if (a.Count == 1 && string.IsNullOrEmpty(textName))
                            return null;
                        foreach (IWebElement item in a)
                        {
                            if (item.GetAttribute("id") == textName)
                                return item;
                        }
                        return null;
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
