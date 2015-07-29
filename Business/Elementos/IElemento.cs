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
        Identificador identificador;

        public IElemento(Identificador Id)
        {
            identificador = Id;
        }
        public abstract void Funcao(IWebDriver pagina);

        public IWebElement GetElemento(IWebDriver pagina)
        {
            try
            {
                switch (identificador.tipoPesquisa)
                {
                    case ElementoPesquisaEnum._id:
                        return pagina.FindElement(By.Id(identificador.id));
                    case ElementoPesquisaEnum._path:
                        return pagina.FindElement(By.XPath(identificador.id));
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
