using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class VistaGeral: IPagina
    {
        public VistaGeral()
            : base(new Elementos.BtnMenu("Vista Geral", Elementos.ElementoPesquisaEnum._id, "Vista Geral"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
