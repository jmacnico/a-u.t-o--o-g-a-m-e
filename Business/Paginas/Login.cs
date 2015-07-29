using Business.Elementos;
using DTO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Configs;

namespace Business.Paginas
{
    public class Login : IPagina
    {
        public Global global { get; private set; }
        public IWebDriver paginaElementos { get; private set; }
        public Registar registar;
        public bool OpenPagina(string url = "http://www.ogame.com.pt")
        {
            paginaElementos.Navigate().GoToUrl(url);
            paginaElementos.Manage().Window.Maximize();
            return true;
        }
        Utilizador utilizador;
        Entrar entrar;
        public Login(Utilizador ObjUtilizador):base(null)
        {
            utilizador = ObjUtilizador;
            entrar = new Entrar(utilizador);
            registar = new Registar(utilizador);
            paginaElementos = new FirefoxDriver();
        }

        public override bool Entrar(IWebDriver pagina)
        {
            try
            {
                if (ValidateLogin(pagina))
                {
                    entrar.Login(pagina);
                    if (!ValidateLogin(pagina))
                    global = new Global(Planetas.GetPlanetas(pagina));
                }
                return !ValidateLogin(pagina);
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

        public void Registar(IWebDriver pagina)
        {
            registar.ResgistarUtilizador(pagina);
        }
        
    }
    public class Entrar
    {
        Textbox txtPassword;
        Textbox txtUsername;
        Button btnEntrar;
        Button btnSubmit;
        Combobox cmbUniverso;

        public Entrar(Utilizador Utilizador)
        {

            txtUsername = new Textbox(CustomConfig.Settings.Buttons["txtuserLogin"].GetIdentificador(), Utilizador.userName);
            txtPassword = new Textbox(CustomConfig.Settings.Buttons["txtPassworLogin"].GetIdentificador(), Utilizador.password);
            btnEntrar = new Button(CustomConfig.Settings.Buttons["btnEntrar"].GetIdentificador());
            cmbUniverso = new Combobox(CustomConfig.Settings.Buttons["cmbUniverso"].GetIdentificador(), Utilizador.universo);
            btnSubmit = new Button(CustomConfig.Settings.Buttons["btnloginSubmit"].GetIdentificador());
        }
        public void Login(IWebDriver pagina)
        {
            try
            {
                btnEntrar.Funcao(pagina);
                txtUsername.Funcao(pagina);
                txtPassword.Funcao(pagina);
                cmbUniverso.Funcao(pagina);
                btnSubmit.Funcao(pagina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class Registar
    {
        Textbox txtPassword;
        Textbox txtUsername;
        Textbox txtEmail;
        Button btnSubmit;
        Combobox cmbUniverso;
        Button aceitarTermos;
        public Registar(Utilizador Utilizador)
        {

            txtUsername = new Textbox(CustomConfig.Settings.Buttons["txtusernameRegister"].GetIdentificador(), Utilizador.userName);
            txtPassword = new Textbox(CustomConfig.Settings.Buttons["txtPasswordRegister"].GetIdentificador(), Utilizador.password);
            txtEmail = new Textbox(CustomConfig.Settings.Buttons["txtEmailRegister"].GetIdentificador(), Utilizador.email);
            cmbUniverso = new Combobox(CustomConfig.Settings.Buttons["cmbServerLoginRegister"].GetIdentificador(), Utilizador.universo, "div");
            btnSubmit = new Button(CustomConfig.Settings.Buttons["btnSubmitRegister"].GetIdentificador());
            aceitarTermos = new Button(CustomConfig.Settings.Buttons["chkAcceptRegister"].GetIdentificador());
        }

        public bool ResgistarUtilizador(IWebDriver pagina)
        {
            try
            {
                txtUsername.Funcao(pagina);
                txtPassword.Funcao(pagina);
                txtEmail.Funcao(pagina);
                cmbUniverso.Funcao(pagina);
                aceitarTermos.Funcao(pagina);
                btnSubmit.Funcao(pagina);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
   
}
