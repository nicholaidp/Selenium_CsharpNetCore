using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Prospecting : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test()
        {
            var randomFname = "";
            var randomLname = "";
            var randomMname = "";
            var randomSalutations = "";
            var randomPhonenumber = "";
            var randomDOB = "";
            var randomCivilStatus = "";
            var randomGender = "";

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
            IWebElement userName = Driver.FindElement(By.Id("input-16"));
            userName.Click();
            userName.SendKeys(Keys.Control + "a" + Keys.Delete);
            userName.SendKeys("marketing@revlv.com");
            //Driver.FindElement(By.Id("input-16")).SendKeys("admin@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            for (int i = 0; i < 39; i++)
            {
                randomGender = RandomGenerator.generateGender();
                randomFname = RandomGenerator.generateFname();
                randomLname = RandomGenerator.generateLname();
                randomMname = RandomGenerator.generateMname();
                randomSalutations = RandomGenerator.generateSalutation();
                randomPhonenumber = RandomGenerator.generatePhonenumber();
                randomDOB = RandomGenerator.generateDOB();
                randomCivilStatus = RandomGenerator.generateCivilStatus();

                System.Threading.Thread.Sleep(1000);
                
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.LinkText("NEW")).Click();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                Driver.FindElement(By.ClassName("v-input--selection-controls__input")).Click();
                Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
                Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
                Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);

                Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname);

                Driver.FindElement(By.Id("input_birthdate")).SendKeys(randomDOB);

                #region civilStatus
                IWebElement civilStatus = Driver.FindElement(By.Id("input_civil_status"));
                civilStatus.SendKeys(randomCivilStatus);
                civilStatus.SendKeys(Keys.Down);
                civilStatus.SendKeys(Keys.Enter);
                #endregion
                #region gender
                IWebElement gender = Driver.FindElement(By.Id("input_gender"));
                gender.SendKeys(randomGender);
                gender.SendKeys(Keys.Down);
                gender.SendKeys(Keys.Enter);
                #endregion
                Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber);
                Driver.FindElement(By.Id("input_email")).SendKeys(randomFname + randomLname + "@gmail.com");
                Driver.FindElement(By.Id("button_next")).Click();
             
            }
        }
    }
}
