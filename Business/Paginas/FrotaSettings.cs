using Business.Elementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class FrotaSettings: IPagina
    {
        public FrotaSettings()
            : base("MenuFrotaSettings")
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
