using Business.Configs;
using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Business
{
    public abstract class IPagina
    {

        Button btnIdentificador;

        public IPagina(string KeyCustomConfig)
        {
            if (!string.IsNullOrEmpty(KeyCustomConfig))
                btnIdentificador = new Button(CustomConfig.Settings.Buttons[KeyCustomConfig].GetIdentificador());
            
            
        }
        public abstract bool ValidateLogin(IWebDriver pagina);

        public virtual bool Entrar(IWebDriver pagina)
        {
            btnIdentificador.Funcao(pagina);
            return true;
        }
    }
}
