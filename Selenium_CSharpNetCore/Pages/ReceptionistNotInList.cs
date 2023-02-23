using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class ReceptionistNotInList : DriverHelper
    {
        [SetUp]
        public void setUp()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {

            int loopCounter = 100;
            var randomFname = "";
            var randomLname = "";
            var randomMname = "";
            var randomSalutations = "";
            var randomPhonenumber = "";
            var randomDOB = "";
            var randomCivilStatus = "";
            var randomOccupations = "";


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

            #region Encoding
            for (int i = 0; i < loopCounter; i++)
            {
                randomFname = RandomGenerator.generateFname();
                randomLname = RandomGenerator.generateLname();
                randomMname = RandomGenerator.generateMname();
                randomSalutations = RandomGenerator.generateSalutation();
                randomPhonenumber = RandomGenerator.generatePhonenumber();
                randomDOB = RandomGenerator.generateDOB();
                randomCivilStatus = RandomGenerator.generateCivilStatus();
                randomOccupations = RandomGenerator.generateOccupation();

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();

                #region Name
                Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
                Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
                Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);
                Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname);
                #endregion

                #region DOB
                //IWebElement dateOfBirth = Driver.FindElement(By.Id("input_birthdate"));
                //dateOfBirth.Click();
                //dateOfBirth.SendKeys(randomDOB);
                #endregion

                #region contactInfo
                Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber);
                Driver.FindElement(By.Id("input_email")).SendKeys(randomFname + randomLname + "@gmail.com");
                #endregion

                #region civilStatus
                IWebElement civilStatus = Driver.FindElement(By.Id("input_civil_status"));
                civilStatus.SendKeys(randomCivilStatus);
                civilStatus.SendKeys(Keys.Down);
                civilStatus.SendKeys(Keys.Enter);
                #endregion

                #region Address
                //IWebElement txtCountry = Driver.FindElement(By.Id("input_country"));
                //txtCountry.Click();
                //txtCountry.SendKeys(Keys.Control + "a" + Keys.Delete);
                //txtCountry.SendKeys("Philippines");
                //System.Threading.Thread.Sleep(2000);
                //txtCountry.SendKeys(Keys.Down);
                //txtCountry.SendKeys(Keys.Enter);

                IWebElement txtProvince = Driver.FindElement(By.Id("input_province"));
                txtProvince.Click();
                txtProvince.SendKeys("Abra");
                System.Threading.Thread.Sleep(2000);
                txtProvince.SendKeys(Keys.Down);
                txtProvince.SendKeys(Keys.Enter);
                IWebElement txtCity = Driver.FindElement(By.Id("input_city"));
                txtCity.Click();
                txtCity.SendKeys("Bucay");
                System.Threading.Thread.Sleep(2000);
                txtCity.SendKeys(Keys.Down);
                txtCity.SendKeys(Keys.Enter);
                #endregion



                IWebElement txtProfession = Driver.FindElement(By.Id("input_profession"));
                txtProfession.SendKeys(randomOccupations);



                System.Threading.Thread.Sleep(1000);
                Driver.FindElement(By.Id("button_next")).Click();
                System.Threading.Thread.Sleep(1000);



            }
            #endregion

            //Tagging attendance
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
            }
        }
    }
}
