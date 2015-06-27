using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class RecursosSettings : IPagina
    {
        public RecursosSettings()
            : base(new Elementos.BtnMenu("Recursos", Elementos.ElementoPesquisaEnum._id,""))
        {

        }
        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
