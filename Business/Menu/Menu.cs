using Business.Elementos;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Menu
{
    public class Menu
    {
        public string Nome { get; private set; }
        public List<IElemento> elementos { get; private set; }

        public Menu()
        {
            elementos = new List<IElemento>();
            elementos.Add(new Listbox("menuTable",ElementoPesquisaEnum._id,"Recursos");
        }

        public bool Open(IWebDriver pagina)
        {
            elementos.FirstOrDefault(x => x.id.Equals("menuTable")).Funcao(pagina);
            return true;
        }
    }
    //public class MenuElemento
    //{
    //    public IElemento btnEvoluir { get; private set; }
    //    public IElemento btnAux { get; private set; }
    //    public MenuElemento(IElemento BtnEvoluir,IElemento BtnAux)
    //    {
    //        btnAux = BtnAux;
    //        btnEvoluir = BtnEvoluir;
    //    }
    //}
}
