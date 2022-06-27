using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class SetQualifications : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            int loopCounter = 7;
            string qualification = "Qualified";

            #region login
            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("admana@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");/
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            #endregion

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement cogButton = Driver.FindElement(By.Id("btn-exhibitor-filter"));
            cogButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            System.Threading.Thread.Sleep(1000);
            IWebElement sortQ1 = Driver.FindElement(By.Id("btn-deck-sort"));
            sortQ1.Click();
            IWebElement filterPending = Driver.FindElement(By.Id("btn-qualification-sort_pending"));
            filterPending.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-close")).Click();


            for (int i = 0; i < loopCounter; i++)
            {
                
                IWebElement btnOption = Driver.FindElement(By.Id("btn-options-0"));
                btnOption.Click();
                IWebElement btnQual = Driver.FindElement(By.Id("btn-qualification-0"));
                btnQual.Click();

                IWebElement comboStatus = Driver.FindElement(By.Id("input-tag"));
                comboStatus.SendKeys(qualification);
                comboStatus.SendKeys(Keys.Down); 
                comboStatus.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(1000);
                Driver.FindElement(By.Id("btn-save")).Click();
                System.Threading.Thread.Sleep(1000);

            }

        }
    }
}
