using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class TableOfficer : DriverHelper
    {
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            int loopcounter = 5;
            var randomIncome = "";
            var randomId = "";



            #region Login
            Driver.Navigate().GoToUrl("https://systems.avlci.com/");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("table.officer@revlv.com");
            Driver.FindElement(By.Id("input-password")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            #endregion

            for (int i = 0; i < loopcounter; i++) {

            randomIncome = RandomGenerator.generateIncome();
            randomId = RandomGenerator.generateIdentifications();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-booker-filter")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-profile-status-sort")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-profile-status-sort_pending")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.Id("btn-close")).Click();
            Driver.FindElement(By.Id("btn-options-0")).Click();
            Driver.FindElement(By.Id("btn-update-0")).Click();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            System.Threading.Thread.Sleep(4000);
            Driver.FindElement(By.Id("button_next")).Click();

             IWebElement inputIncome = Driver.FindElement(By.Id("input_income"));
            inputIncome.SendKeys(randomIncome);
            inputIncome.SendKeys(Keys.Down);
            inputIncome.SendKeys(Keys.Enter);

            IWebElement identifications = Driver.FindElement(By.Id("input_identification"));
            identifications.SendKeys(randomId);
            identifications.SendKeys(Keys.Down);
            identifications.SendKeys(Keys.Enter);

            Driver.FindElement(By.ClassName("input_question_one_yes")).Click();
            Driver.FindElement(By.ClassName("input_question_two_yes")).Click();
            Driver.FindElement(By.ClassName("input_question_three_yes")).Click();

            Driver.FindElement(By.Id("button_submit")).Click();

            }
        }
    }
}
