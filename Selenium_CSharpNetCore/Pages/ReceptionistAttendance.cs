using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class ReceptionistAttendance : DriverHelper
    {
        [SetUp]
        public void setUp()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            int loopCounter = 10;

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

            for (int i = 0; i < loopCounter; i++)
            {

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.Id("btn-booker-filter")).Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-profile-status-sort")).Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-attended-sort_pending")).Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-close")).Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-options-0")).Click();
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-attended-0")).Click();
                Driver.FindElement(By.Id("input_date_attended")).SendKeys("08/30/2022");
                Driver.FindElement(By.Id("btn-save")).Click();


                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
