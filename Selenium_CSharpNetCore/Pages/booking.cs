using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class booking : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {
            int loopCounter = 5;
            var status = "book";
            var randomPresentationAnswer = "";
            var randomPresentationAttendance = "";
            var randomDevice = "";
            #region login

            

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("booker2@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            #endregion
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IWebElement cogButton = Driver.FindElement(By.Id("btn-booker-filter"));
            cogButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            System.Threading.Thread.Sleep(1000);
            IWebElement sortQ1 = Driver.FindElement(By.Id("btn-deck-sort"));
            sortQ1.Click();
            IWebElement filterPending = Driver.FindElement(By.Id("btn-status-sort_pending"));
            filterPending.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-close")).Click();

            for (int i = 0; i < loopCounter; i++)
            {
                randomPresentationAnswer = RandomGenerator.generatePresentationAnswer();
                randomPresentationAttendance = RandomGenerator.generatePresentationAttendance();
                randomDevice = RandomGenerator.generateDevice();    

                IWebElement btnOption = Driver.FindElement(By.Id("btn-options-0"));
                btnOption.Click();
                IWebElement btnQual = Driver.FindElement(By.Id("btn-qualification-0"));
                btnQual.Click();

                IWebElement comboStatus = Driver.FindElement(By.Id("input-tag"));
                comboStatus.SendKeys(status);
                comboStatus.SendKeys(Keys.Down);
                comboStatus.SendKeys(Keys.Enter);
                Driver.FindElement(By.Id("input_book_datetime")).SendKeys("07042022" + Keys.Tab + "1233PM");

                IWebElement preAns = Driver.FindElement(By.ClassName(randomPresentationAnswer));
                preAns.Click();
                System.Threading.Thread.Sleep(1000);
                IWebElement deviceUsed = Driver.FindElement(By.Id("input_device"));
                deviceUsed.SendKeys(randomDevice);

                deviceUsed.SendKeys(Keys.Down);
                deviceUsed.SendKeys(Keys.Enter);

                System.Threading.Thread.Sleep(1000);
                IWebElement preAtt = Driver.FindElement(By.ClassName(randomPresentationAttendance));
                preAtt.Click();
                System.Threading.Thread.Sleep(1000);
                 Driver.FindElement(By.Id("btn-save")).Click();
                System.Threading.Thread.Sleep(1000);

            }

        }
    }
}
