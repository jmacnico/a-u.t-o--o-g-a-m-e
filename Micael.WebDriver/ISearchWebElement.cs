using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Micael.WebDriver
{
    interface ISearchWebElement
    {
        public static IWebElement GetElemento(IWebDriver pagina, string Query);
    }
}
