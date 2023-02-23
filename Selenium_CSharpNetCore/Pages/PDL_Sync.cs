using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_CSharpNetCore.Pages
{
    internal class PDL_Sync: DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            #region Login
            Driver.Navigate().GoToUrl("http://27.110.173.31:9001/auth/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.SendKeys("raccount20160999");
            Driver.FindElement(By.Id("input-password")).SendKeys("P@ssw0rd!@#");
            Driver.FindElement(By.Id("btn-login")).Click();

            System.Threading.Thread.Sleep(5000);
            Driver.Navigate().GoToUrl("http://27.110.173.31:9001/imis/inmate-sync-logs/");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Id("0")).Click();
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Id("btn-new")).Click();



            #endregion
        }
    }
}
