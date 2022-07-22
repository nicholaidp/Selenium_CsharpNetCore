using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class tagQ1 : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            int loopCounter= 10;  
            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("admana@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");/
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            for (int i = 0; i < loopCounter; i++)
            {
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                IWebElement cogButton = Driver.FindElement(By.Id("btn-exhibitor-filter"));
                cogButton.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                System.Threading.Thread.Sleep(1000);

                //IWebElement sortQual = Driver.FindElement(By.Id("btn-deck-sort"));
                //sortQual.Click();
                //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                //IWebElement filterQualified = Driver.FindElement(By.Id("btn-qualification-sort_qualified"));
                //filterQualified.Click();

                IWebElement sortQ1 = Driver.FindElement(By.Id("btn-q1-sort"));
                sortQ1.Click();
                IWebElement filterQ1 = Driver.FindElement(By.Id("btn-q1-sort_no"));
                filterQ1.Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.Id("btn-close")).Click();
                IWebElement btnOption = Driver.FindElement(By.Id("btn-options-0"));
                btnOption.Click();
                IWebElement btnQualification = Driver.FindElement(By.Id("btn-tag-0"));
                btnQualification.Click();
                System.Threading.Thread.Sleep(1500);
                Driver.FindElement(By.Id("btn-save")).Click();
                System.Threading.Thread.Sleep(3000);

            }

        }
    }
}
