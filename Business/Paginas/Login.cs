using Business.Elementos;
using DTO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Paginas
{
    public class Login : IPagina
    {
        Utilizador utilizador;
        Textbox txtPassword;
        Textbox txtUsername;
        Button btnEntrar;
        Button btnSubmit;
        Combobox cmbUniverso;
        public Global global { get; private set; }
        public IWebDriver paginaElementos { get; private set; }
        
        public bool OpenPagina(string url = "http://www.ogame.com.pt")
        {
            paginaElementos.Navigate().GoToUrl(url);
            paginaElementos.Manage().Window.Maximize();
            return true;
        }
        public Login(Utilizador Utilizador) : base (null)
        {
            utilizador = Utilizador;
            paginaElementos = new FirefoxDriver();
            txtUsername = new Textbox("usernameLogin",ElementoPesquisaEnum._id,utilizador.userName);
            txtPassword = new Textbox("passwordLogin", ElementoPesquisaEnum._id, utilizador.password);
            btnEntrar = new Button("loginBtn", ElementoPesquisaEnum._id);
            cmbUniverso = new Combobox("serverLogin", ElementoPesquisaEnum._id,utilizador.universo);
            btnSubmit = new Button("loginSubmit", ElementoPesquisaEnum._id);
        }
        public override bool Entrar(IWebDriver pagina)
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
                    
                    global = new Global(Planetas.GetPlanetas(pagina));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public override bool ValidateLogin(IWebDriver pagina)
        {
            if (pagina.Title.ToUpper().Contains("Página Inicial Ogame".ToUpper()))
                return true;
            return false;
        
        }
    }
}
