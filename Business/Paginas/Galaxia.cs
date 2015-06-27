using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Galaxia: IPagina
    {
        public Galaxia()
            : base(new Elementos.BtnMenu("Galáxia", Elementos.ElementoPesquisaEnum._id, "Galáxia"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
