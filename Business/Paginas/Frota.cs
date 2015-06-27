using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Frota: IPagina
    {
        public Frota()
            : base(new Elementos.BtnMenu("Frota", Elementos.ElementoPesquisaEnum._id, "Frota"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
