using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Global
    {
        public int pontos { get; private set; }
        public List<Planetas> listPlanetas { get; private set; }

        public Menu.Menu menu { get; private set; }
       public Global(List<Planetas> ListPlanetas)
        {
            listPlanetas = ListPlanetas;
            menu = new Menu.Menu();
            
        }


        
    }
}
