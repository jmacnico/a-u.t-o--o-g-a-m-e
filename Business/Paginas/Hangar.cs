using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Hangar: IPagina
    {
        public Hangar()
            : base(new Elementos.BtnMenu("Hangar", Elementos.ElementoPesquisaEnum._id, "Hangar"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
