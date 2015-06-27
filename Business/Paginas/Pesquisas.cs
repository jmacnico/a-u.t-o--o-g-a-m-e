using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    class Pesquisas: IPagina
    {
        public Pesquisas()
            : base(new Elementos.BtnMenu("Pesquisas", Elementos.ElementoPesquisaEnum._id, "Pesquisas"))
        {

        }
    
public override bool ValidateLogin(OpenQA.Selenium.IWebDriver pagina)
{
 	throw new NotImplementedException();
}
}
}
