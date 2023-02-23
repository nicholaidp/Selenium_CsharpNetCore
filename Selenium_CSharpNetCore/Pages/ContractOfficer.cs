using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class ContractOfficer : DriverHelper
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
            txtUsername.SendKeys("contract@revlv.com");
            Driver.FindElement(By.Id("input-password")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            #endregion


            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.Id("btn-options-0")).Click();
            Driver.FindElement(By.Id("btn-edit-0")).Click();

            IWebElement membershipType = Driver.FindElement(By.Id("input-membership_type"));
            membershipType.SendKeys("Regular");
            membershipType.SendKeys(Keys.Down);
            membershipType.SendKeys(Keys.Enter);

            IWebElement homeResort = Driver.FindElement(By.Id("input-home_resort"));
            homeResort.SendKeys("Astoria Boracay");
            homeResort.SendKeys(Keys.Down);
            homeResort.SendKeys(Keys.Enter);

            IWebElement unit = Driver.FindElement(By.Id("input-room_type"));
            unit.SendKeys("1BR");
            unit.SendKeys(Keys.Down);
            unit.SendKeys(Keys.Enter);

            IWebElement period = Driver.FindElement(By.Id("input-period"));
            period.SendKeys("Full");
            period.SendKeys(Keys.Down);
            period.SendKeys(Keys.Enter);

            IWebElement terms = Driver.FindElement(By.Id("input-payment_terms"));
            terms.SendKeys("Installment");
            terms.SendKeys(Keys.Down);
            terms.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(1000);
            IWebElement months = Driver.FindElement(By.Id("input-months"));
            months.SendKeys("36");
            months.SendKeys(Keys.Down);
            months.SendKeys(Keys.Enter);

            IWebElement paymentMode = Driver.FindElement(By.Id("input-payment_mode"));
            paymentMode.SendKeys("Cash");
            paymentMode.SendKeys(Keys.Down);
            paymentMode.SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("input-amount")).SendKeys("15000");


            IWebElement orm = Driver.FindElement(By.Id("input-owner_relations_manager"));
            orm.SendKeys("Mark Alonzo");
            orm.SendKeys(Keys.Down);
            orm.SendKeys(Keys.Enter);


            IWebElement tovm = Driver.FindElement(By.Id("input-turnover_officer"));
            tovm.SendKeys("Mark Alonzo");
            tovm.SendKeys(Keys.Down);
            tovm.SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("btn-onboard")).Click();
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.Id("btn_confirm_onboard")).Click();


        }
    }
}
