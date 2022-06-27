using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Exhibitor : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test()
        {
            #region Vars

            int loopCounter = 5;

            var randomFname = "";
            var randomLname = "";
            var randomMname = "";
            var randomSalutations = "";
            var randomPhonenumber = "";
            var randomDOB = "";
            var randomCivilStatus = "";
            var randomGender = "";
            var randomBooker = "";
            var randomExibitor = "";
            var randomOccupations = "";
            var randomCountry = "";
            var randomProvince = "";
            var randomCity = "";
            var randomSource = "";
            var randomSubdivision = "";
            var randomStreet = "";
            var randomBuildingnum = "";
            var randomPostalCode = "";
            var randomProfessionYears = "";
            var randomIncome = "";
            var randomWork = "";
            var randomspouseOccupation = "";
            var randomstubNum = "";
            var randomVM = "";






            #endregion



            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            IWebElement txtUsername = Driver.FindElement(By.Id("input-username"));
            txtUsername.Click();
            txtUsername.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername.SendKeys("exhibitor@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            for (int i = 0; i < loopCounter; i++)
            {
                #region Vars
                randomFname = RandomGenerator.generateFname();
                randomLname = RandomGenerator.generateLname();
                randomMname = RandomGenerator.generateMname();
                randomSalutations = RandomGenerator.generateSalutation();
                randomPhonenumber = RandomGenerator.generatePhonenumber();
                randomDOB = RandomGenerator.generateDOB();
                randomCivilStatus = RandomGenerator.generateCivilStatus();
                randomGender = RandomGenerator.generateGender();
                randomBooker = RandomGenerator.generateBooker();
                randomOccupations = RandomGenerator.generateOccupation();
                randomSource = RandomGenerator.generateSource();
                randomSubdivision = RandomGenerator.generateSubdivision();
                randomStreet = RandomGenerator.generateStreet();
                randomBuildingnum = RandomGenerator.generateBuildingNum();
                randomPostalCode = RandomGenerator.generatePostalCode();
                randomProfessionYears = RandomGenerator.generateProfessionYears();
                randomIncome = RandomGenerator.generateIncome();
                randomWork = RandomGenerator.generateWork();
                randomspouseOccupation = RandomGenerator.generateOccupation();
                randomstubNum = RandomGenerator.generatePhonenumber();
                randomVM = RandomGenerator.generateVenueManager();

                #endregion


                System.Threading.Thread.Sleep(1000);

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();
                System.Threading.Thread.Sleep(2000);
                //IWebElement exhibitDate = Driver.FindElement(By.Id("input_exhibit_date"));
                //exhibitDate.SendKeys(Keys.Control + "a" + Keys.Delete);
                //exhibitDate.SendKeys("06/16/2022");
                Driver.FindElement(By.Id("input_exhibit_time")).SendKeys("1233PM");

                #region Name
                Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
                Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
                Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);
                Driver.FindElement(By.Id("input_last_name")).SendKeys("ry-  " +randomLname);
                #endregion

                #region source
                IWebElement txtSource = Driver.FindElement(By.Id("input_source"));
                txtSource.SendKeys(randomSource);
                txtSource.SendKeys(Keys.Down);
                txtSource.SendKeys(Keys.Enter);
                #endregion

                #region sourceRemarks
                IWebElement txtSourceRemarks = Driver.FindElement(By.Id("input-source-remark"));
                txtSourceRemarks.SendKeys("Test");
                txtSourceRemarks.SendKeys(Keys.Down);
                txtSourceRemarks.SendKeys(Keys.Enter);
                #endregion

                #region Vm
                IWebElement txtVM = Driver.FindElement(By.Id("input-vm"));
                txtVM.Click();
                txtVM.SendKeys(randomVM);
                System.Threading.Thread.Sleep(1000);
                txtVM.SendKeys(Keys.Down);
                txtVM.SendKeys(Keys.Enter);
                #endregion

                Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber);
                Driver.FindElement(By.Id("input_email")).SendKeys(randomFname + randomLname + "@gmail.com");
                //Driver.FindElement(By.Id("input_birthdate")).SendKeys(randomDOB);

                IWebElement dateOfBirth = Driver.FindElement(By.Id("input_birthdate"));
                dateOfBirth.Click();
                dateOfBirth.SendKeys(randomDOB);

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

                #region additionalAddress
                //IWebElement txtSubdivision = Driver.FindElement(By.Id("input_subdivision"));
                //txtSubdivision.SendKeys(randomSubdivision);
                //IWebElement txtStreet = Driver.FindElement(By.Id("input_street"));
                //txtStreet.SendKeys(randomStreet);
                //IWebElement txtBuildingNum = Driver.FindElement(By.Id("input_building_number"));
                //txtBuildingNum.SendKeys(randomBuildingnum);
                //IWebElement txtPostalc = Driver.FindElement(By.Id("input_postal_code"));
                //txtPostalc.SendKeys(randomPostalCode);
                #endregion

                #region gender
                //IWebElement gender = Driver.FindElement(By.Id("input_gender"));
                //if (randomSalutations == "Mr")
                //{
                //    gender.SendKeys("Male");
                //    gender.SendKeys(Keys.Down);
                //    gender.SendKeys(Keys.Enter);
                //}
                //else if (randomSalutations == "Ms" || randomSalutations == "Mrs")
                //{
                //    gender.SendKeys("Female");
                //    gender.SendKeys(Keys.Down);
                //    gender.SendKeys(Keys.Enter);
                //}
                //else
                //{
                //    gender.SendKeys(randomGender);
                //    gender.SendKeys(Keys.Down);
                //    gender.SendKeys(Keys.Enter);
                //}
                //IWebElement txtBooker = Driver.FindElement(By.Id("input-booker"));
                //txtBooker.SendKeys(randomBooker);
                //txtBooker.SendKeys(Keys.Down);
                //txtBooker.SendKeys(Keys.Enter);
                //IWebElement txtExibitor = Driver.FindElement(By.Id("input-surveyer"));
                //txtExibitor.SendKeys(randomExibitor);
                //txtExibitor.SendKeys(Keys.Down);
                //txtExibitor.SendKeys(Keys.Enter);
                //IWebElement txtDesignation = Driver.FindElement(By.Id("input_designation"));
                //txtDesignation.SendKeys(randomOccupations);

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
                #endregion

                #region spouse
                Driver.FindElement(By.Id("input_spouse_occupation")).SendKeys(randomspouseOccupation);
                Driver.FindElement(By.Id("input_stub_number")).SendKeys(randomstubNum);
                #endregion

                IWebElement btnSave = Driver.FindElement(By.Id("button_save"));
            
                btnSave.Click();
                //System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
