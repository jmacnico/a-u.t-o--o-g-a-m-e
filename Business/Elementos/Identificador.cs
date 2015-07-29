using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Elementos
{
    public class Identificador
    {
        public ElementoPesquisaEnum tipoPesquisa { get; private set; }
        public string id { get; private set; }
        public Identificador(string Id, ElementoPesquisaEnum TipoPesquisa)
        {
            tipoPesquisa = TipoPesquisa;
            id = Id;
        }
    }
}
