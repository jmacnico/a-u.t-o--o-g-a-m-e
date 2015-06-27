using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Recursos : IPagina
    {
        public Recursos() :base(new Elementos.BtnMenu("Recursos",Elementos.ElementoPesquisaEnum._id,"Recursos"))
        {

        }
        public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
        {
            throw new NotImplementedException();
        }

        
    }
}
