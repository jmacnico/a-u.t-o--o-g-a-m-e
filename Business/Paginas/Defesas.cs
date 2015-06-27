using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Defesas: IPagina
    {
        public Defesas()
            : base(new Elementos.BtnMenu("Defesas", Elementos.ElementoPesquisaEnum._id, "Defesas"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
