using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Micael.WebDriver
{
    public class SearchWebElement :ISearchWebElement
    {
        public static IWebElement GetElemento(IWebDriver pagina, string Query)
        {
            try
            {
                string[] partQuery = Query.Split(';');
                IWebElement menu = pagina.FindElement(By.Id("menuTable"));
                var lstli = menu.FindElements(By.TagName("li"));
                var li = lstli.FirstOrDefault(x => x.Text == partQuery[0]);
                return li.FindElements(By.TagName("a")).FirstOrDefault(x => x.Text == partQuery[1]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private static IWebElement GetById(IWebDriver pagina, string Id)
        {

            return pagina.FindElement(By.Id(Id));
        }
        private static ReadOnlyCollection<IWebElement> GetById(IWebDriver pagina, string Id)
        {
            return pagina.FindElements(By.Id(Id));
        }
        private static IWebElement GetByTagName(IWebDriver pagina, string TagName)
        {

            return pagina.FindElement(By.TagName(TagName));
        }
        private static ReadOnlyCollection<IWebElement> GetByTagName(IWebDriver pagina, string TagName)
        {
            return pagina.FindElements(By.TagName(TagName));
        }

        private static IWebElement GetByText(IWebDriver pagina, string Text)
        {

            return pagina.FindElement(By.LinkText(Text));
        }
        private static ReadOnlyCollection<IWebElement> GetByText(IWebDriver pagina, string Text)
        {
            return pagina.FindElements(By.LinkText(Text));
        }

        private static IWebElement GetByPartialText(IWebDriver pagina, string PartialText)
        {

            return pagina.FindElement(By.PartialLinkText(PartialText));
        }
        private static ReadOnlyCollection<IWebElement> GetByPartialText(IWebDriver pagina, string PartialText)
        {
            return pagina.FindElements(By.PartialLinkText(PartialText));
        }
    }
}
