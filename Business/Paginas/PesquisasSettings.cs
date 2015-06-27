using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class PesquisasSettings: IPagina
    {
        public PesquisasSettings()
            : base(new Elementos.BtnMenu("Pesquisas", Elementos.ElementoPesquisaEnum._id, ""))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
