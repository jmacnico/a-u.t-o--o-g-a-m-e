using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using Business;
using System.Configuration;
using Business.Menu;
using Business.Elementos;


namespace TestesUnitarios
{
    
    class Program
    {
        static void Main(string[] args)
        {            
            Utilizador utilizador = new Utilizador(ConfigurationSettings.AppSettings["Username"].ToString(), ConfigurationSettings.AppSettings["Password"].ToString(), ConfigurationSettings.AppSettings["Universo"].ToString());
            Login login = new Login(utilizador);            
            NegocioGeral.OpenPagina();
            login.Open(NegocioGeral.PaginaElementos);

            Menu menu = new Menu();
            Combobox cb = (Combobox)menu.elementos[0];
            cb.selectValue = "Recursos";
             
            menu.Open(NegocioGeral.PaginaElementos);
        }
    }
}
