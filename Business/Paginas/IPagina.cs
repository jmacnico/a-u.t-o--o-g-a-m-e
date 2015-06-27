using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Business
{
    public abstract class IPagina
    {

        private Elementos.BtnMenu btnIdentificador;

        public IPagina(Elementos.BtnMenu Identificador)
        {
            btnIdentificador = Identificador;
        }
        public abstract bool ValidateLogin(IWebDriver pagina);

        public void Entrar(IWebDriver pagina)
        {
            btnIdentificador.Funcao(pagina);
        }
    }
}
