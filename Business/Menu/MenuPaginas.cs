using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Menu
{
   public class MenuPaginas
    {
        IPagina principal;
        IPagina settings;
        public MenuPaginas(IPagina Principal,IPagina Settings)
        {
            principal = Principal;
            settings = Settings;
        } 
       public void EntarPrincipal(IWebDriver pagina)
        {
            principal.Entrar(pagina);
        }
       public void EntarSettings(IWebDriver pagina)
       {
           settings.Entrar(pagina);
       }

       public IPagina GetPrincipal()
       {
           return principal;
       }
       public IPagina GetSettings()
       {
           return settings;
       }
   }
}
