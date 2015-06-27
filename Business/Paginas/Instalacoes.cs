using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Instalacoes: IPagina
    {
        public Instalacoes()
            : base(new Elementos.BtnMenu("Instalações", Elementos.ElementoPesquisaEnum._id, "Instalações"))
        {

        }

        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }
    }
}
