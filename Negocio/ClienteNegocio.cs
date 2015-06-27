using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Entities;

namespace Negocio
{
    public class ClienteNegocio
    {
        public bool Login(Utilizador utilizador, IWebDriver driver)
        {
            IWebElement buttonEntrar = driver.FindElement(By.Id("loginBtn"));
            buttonEntrar.Click();
            IWebElement username = driver.FindElement(By.Id("usernameLogin"));
            username.SendKeys(utilizador.userName);
            IWebElement passwordLogin = driver.FindElement(By.Id("passwordLogin"));
            passwordLogin.SendKeys(utilizador.password);
            IWebElement serverLogin = driver.FindElement(By.Id("serverLogin"));
            IList<IWebElement> AllDropDownList = serverLogin.FindElements(By.TagName("option"));
            foreach (var item in AllDropDownList)
            {
                if (item.Text.ToUpper() == utilizador.universo.ToUpper())
                {
                    item.Click();
                    item.SendKeys(Keys.Enter);
                }
            }
            IWebElement btnEntrar = driver.FindElement(By.Id("loginSubmit"));
            btnEntrar.Click();
            return true;
        }
    }
}
