using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Confirmation : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            int loopCounter = 2;
            string status = "";


            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("tan@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            for (int i = 0; i < loopCounter; i++)
            {
                status = RandomGenerator.generateConfStatus();

                IWebElement btnOption = Driver.FindElement(By.Id("btn-options-0"));
                btnOption.Click();
                IWebElement btnQual = Driver.FindElement(By.Id("btn-approval-0"));
                btnQual.Click();

                IWebElement comboStatus = Driver.FindElement(By.Id("input-tag"));
                comboStatus.SendKeys(status);
                comboStatus.SendKeys(Keys.Down);
                comboStatus.SendKeys(Keys.Enter);


            
                System.Threading.Thread.Sleep(1000);
                Driver.FindElement(By.Id("btn-save")).Click();
                System.Threading.Thread.Sleep(1000);

            }



        }
    }
}
