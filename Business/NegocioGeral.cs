using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Xml;
using System.IO;

namespace Business
{
    public static class NegocioGeral
    {
        private static IWebDriver _paginaElementos;

        public static IWebDriver PaginaElementos
        {
            get
            {
                if (_paginaElementos == null)
                {
                    _paginaElementos = new FirefoxDriver();
                }
                return _paginaElementos;
            }
        }

        public static bool OpenPagina(string url = "http://www.ogame.com.pt")
        {
            PaginaElementos.Navigate().GoToUrl(url);
            PaginaElementos.Manage().Window.Maximize();
            return true;
        }
    }
}
