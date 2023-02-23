using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class VenueManager : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test()
        {
            #region Login
            Driver.Navigate().GoToUrl("https://systems.avlci.com/");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("receptionist@revlv.com");
            Driver.FindElement(By.Id("input-password")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            #endregion
        }
    }
}
