using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public abstract class IPagina
    {
        public abstract bool ValidateLogin(IWebDriver pagina);
    }
}
