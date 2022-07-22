using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Type2Booker : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test1()
        {

            int loopCounter = 20;
            string randomSource = "";
            var randomFname = "";
            var randomLname = "";
            var randomMname = "";
            var randomSalutations = "";
            var randomPhonenumber = "";
            var randomDOB = "";
            var randomCivilStatus = "";
            var randomOccupations = "";
            var randomCountry = "";
            var randomProvince = "";
            var randomCity = "";
            var randomProfessionYears = "";
            var randomIncome = "";
            var randomWork = "";
            var randomspouseOccupation = "";
            var randomstubNum = "";
            var randomVM = "";
            var randomPresentationAnswer = "";
            var randomPresentationAttendance = "";
            var randomDevice = "";
            var randomReferredBy = "";
            string randomAge;

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("bookert4@revlv.com");
            Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();

            for(int i = 0; i < loopCounter; i++)
            {
                randomSource = RandomGenerator.generateT2();
                randomFname = RandomGenerator.generateFname();
                randomLname = RandomGenerator.generateLname();
                randomMname = RandomGenerator.generateMname();
                randomSalutations = RandomGenerator.generateSalutation();
                randomPhonenumber = RandomGenerator.generatePhonenumber();
                randomDOB = RandomGenerator.generateDOB();
                randomCivilStatus = RandomGenerator.generateCivilStatus();
                randomOccupations = RandomGenerator.generateOccupation();
                randomProfessionYears = RandomGenerator.generateProfessionYears();
                randomIncome = RandomGenerator.generateIncome();
                randomWork = RandomGenerator.generateWork();
                randomspouseOccupation = RandomGenerator.generateOccupation();
                randomstubNum = RandomGenerator.generatePhonenumber();
                randomVM = RandomGenerator.generateVenueManager();
                randomPresentationAnswer = RandomGenerator.generatePresentationAnswer();
                randomPresentationAttendance = RandomGenerator.generatePresentationAttendance();
                randomDevice = RandomGenerator.generateDevice();
                randomReferredBy = RandomGenerator.generateReferredBy();
                randomAge = RandomGenerator.generateAge();

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();

               
                #region source
                IWebElement txtSource = Driver.FindElement(By.Id("input_source"));
                txtSource.SendKeys(randomSource);
                txtSource.SendKeys(Keys.Down);
                txtSource.SendKeys(Keys.Enter);
                #endregion

                //if (randomSource == "ROI")
                //{
                //    Driver.FindElement(By.Id("input-referred_by")).SendKeys(randomReferredBy);
                //}

                //Driver.FindElement(By.Id("input_exhibit_time")).SendKeys("1233PM");

                #region Name
                Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
                Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
                Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);
                Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname);
                #endregion


                Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber);
                Driver.FindElement(By.Id("input_email")).SendKeys(randomFname + randomLname + "@gmail.com");

                //IWebElement dateOfBirth = Driver.FindElement(By.Id("input_birthdate"));
                //dateOfBirth.Click();
                //dateOfBirth.SendKeys(randomDOB);
                IWebElement age = Driver.FindElement(By.Id("input_age"));
                age.SendKeys(randomAge);


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

                #region workInfo

                IWebElement txtProfession = Driver.FindElement(By.Id("input_profession"));
                txtProfession.SendKeys(randomOccupations);
                IWebElement inputYears = Driver.FindElement(By.Id("input_profession_years"));
                inputYears.SendKeys(randomProfessionYears);
                IWebElement txtCurrentCompany = Driver.FindElement(By.Id("input_current_company"));
                txtCurrentCompany.SendKeys("Confidential");
                IWebElement ddIncome = Driver.FindElement(By.Id("input_income"));
                ddIncome.SendKeys(randomIncome);
                ddIncome.SendKeys(Keys.Down);
                ddIncome.SendKeys(Keys.Enter);
                IWebElement ddWork = Driver.FindElement(By.Id("input_work"));
                ddWork.SendKeys(randomWork);
                ddWork.SendKeys(Keys.Down);
                ddWork.SendKeys(Keys.Enter);
                Driver.FindElement(By.Id("input_spouse_occupation")).SendKeys(randomspouseOccupation);

                #endregion

                #region Presentation
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
                #endregion

                IWebElement bookDate = Driver.FindElement(By.Id("input_booking_date"));
                bookDate.SendKeys("07/07/2022");


                IWebElement bookTime = Driver.FindElement(By.Id("input_booking_time"));
                bookTime.SendKeys("1038AM");
                #region Vm
                IWebElement txtVM = Driver.FindElement(By.Id("input-vm"));
                txtVM.Click();
                txtVM.SendKeys(randomVM);
                System.Threading.Thread.Sleep(1000);
                txtVM.SendKeys(Keys.Down);
                txtVM.SendKeys(Keys.Enter);
                #endregion

                System.Threading.Thread.Sleep(1000);
                Driver.FindElement(By.Id("button_save")).Click();
                System.Threading.Thread.Sleep(1000);



            }
        }
    }
}
