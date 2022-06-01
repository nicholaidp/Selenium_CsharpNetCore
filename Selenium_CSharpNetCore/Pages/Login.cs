using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Login : DriverHelper
    {

        IWebElement txtUsername => Driver.FindElement(By.Id("input-16"));
        IWebElement txtPassword => Driver.FindElement(By.Id("input-20"));   
        IWebElement btnLogin => Driver.FindElement(By.ClassName("v-btn__content"));

        public void enterUsernameAndPassword(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
        }
        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
