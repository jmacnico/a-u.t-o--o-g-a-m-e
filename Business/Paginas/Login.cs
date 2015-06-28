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
        Utilizador utilizador;
        Textbox txtPassword;
        Textbox txtUsername;
        Button btnEntrar;
        Button btnSubmit;
        Combobox cmbUniverso;
        Button PasswordLogin;
        public Login(Utilizador Utilizador)
        {
            utilizador = Utilizador;
            txtUsername = new Textbox("usernameLogin",ElementoPesquisaEnum._id,utilizador.userName);
            txtPassword = new Textbox("passwordLogin", ElementoPesquisaEnum._id, utilizador.password);
            btnEntrar = new Button("loginBtn", ElementoPesquisaEnum._id);
            cmbUniverso = new Combobox("serverLogin", ElementoPesquisaEnum._id,utilizador.universo);
            btnSubmit = new Button("loginSubmit", ElementoPesquisaEnum._id);
        }
        public bool Open(IWebDriver pagina)
        {
            try
            {
                if (ValidateLogin(pagina))
                {
                    btnEntrar.Funcao(pagina);
                    txtUsername.Funcao(pagina);
                    txtPassword.Funcao(pagina);
                    cmbUniverso.Funcao(pagina);
                    btnSubmit.Funcao(pagina);
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
