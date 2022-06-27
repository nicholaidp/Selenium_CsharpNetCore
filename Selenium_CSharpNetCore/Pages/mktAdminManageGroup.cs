using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_CSharpNetCore.Pages
{
    internal class mktAdminManageGroup : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        public void Test1()
        {
            #region Login

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("garcia@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            #endregion


        }
    }
}
