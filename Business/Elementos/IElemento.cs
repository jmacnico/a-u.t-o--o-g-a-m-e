using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace Business.Elementos
{
    public abstract class IElemento
    {
        public ElementoPesquisaEnum tipoPesquisa { get; private set; }
        public string id { get; private set; }

        public IElemento(string Id,ElementoPesquisaEnum TipoPesquisa)
        {
            tipoPesquisa = TipoPesquisa;
            id = Id;
        }
        public abstract void Funcao(IWebDriver pagina);

        public virtual IWebElement GetElemento(IWebDriver pagina)
        {
            try
            {
                switch (tipoPesquisa)
                {
                    case ElementoPesquisaEnum._id:
                        return pagina.FindElement(By.Id(id));
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
