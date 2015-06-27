using Business.Elementos;
using DTO;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class Login
    {
        public Utilizador utilizador { get; private set; }
        public List<IElemento> elementos { get; private set; }

        public Login(Utilizador Utilizador)
        {
            utilizador = Utilizador;
            elementos = new List<IElemento>();
            elementos.Add(new Textbox("usernameLogin",ElementoPesquisaEnum._id,utilizador.userName));
            elementos.Add(new Textbox("passwordLogin", ElementoPesquisaEnum._id, utilizador.password));
            elementos.Add(new Button("loginBtn", ElementoPesquisaEnum._id));
            elementos.Add(new Combobox("serverLogin", ElementoPesquisaEnum._id,utilizador.universo));
            elementos.Add(new Button("loginSubmit", ElementoPesquisaEnum._id));
        }
        public bool Open(IWebDriver pagina)
        {
            try
            {
                if (ValidateLogin(pagina))
                {
                    elementos.FirstOrDefault(x => x.id.Equals("loginBtn")).Funcao(pagina);
                    elementos.FirstOrDefault(x => x.id.Equals("usernameLogin")).Funcao(pagina);
                    elementos.FirstOrDefault(x => x.id.Equals("passwordLogin")).Funcao(pagina);
                    elementos.FirstOrDefault(x => x.id.Equals("serverLogin")).Funcao(pagina);
                    elementos.FirstOrDefault(x => x.id.Equals("loginSubmit")).Funcao(pagina);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ValidateLogin(IWebDriver pagina)
        {
            if (pagina.Title.ToUpper().Contains("Página Inicial Ogame".ToUpper()))
                return true;
            return false;
        }
    }
}
