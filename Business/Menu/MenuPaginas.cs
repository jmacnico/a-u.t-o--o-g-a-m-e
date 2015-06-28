using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Menu
{
   public class MenuPaginas
    {
        public IPagina principal { get; private set; }
        public IPagina settings { get; private set; }
        //public IPagina pagina { get; private set; }
        public MenuPaginas(IPagina Principal,IPagina Settings)//, IPagina Pagina)
        {
            principal = Principal;
            settings = Settings;
            //pagina = Pagina;
        } 
   }
}
