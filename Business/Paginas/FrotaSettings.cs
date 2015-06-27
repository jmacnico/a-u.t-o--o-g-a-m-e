using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class FrotaSettings: IPagina
    {
        public FrotaSettings()
            : base(new Elementos.BtnMenu("Frota", Elementos.ElementoPesquisaEnum._id, ""))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
