using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_CSharpNetCore
{
    public class Tests : DriverHelper
    {
    
        [SetUp]
        public void Setup()
        {

            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]


        public void Test1()
        {
            var randomFname = RandomGenerator.generateFname();
            var randomLname = RandomGenerator.generateLname();
            var randomMname = RandomGenerator.generateMname();
            var randomSalutations = RandomGenerator.generateSalutation();
            var randomPhonenumber = RandomGenerator.generatePhonenumber();
            var randomOccupations = RandomGenerator.generateOccupation();
            var randomIncome = RandomGenerator.generateIncome();
            var randomCountry = RandomGenerator.generateCountry();
            //Driver.Navigate().GoToUrl("http://localhost/attendance");
            //Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
           

            Driver.Manage().Window.Maximize();
           

            Driver.FindElement(By.Id("input-16")).SendKeys("kslimlengco@revlv.com");
            Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.LinkText("NEW")).Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
            Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
            Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);

            Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname);

            Driver.FindElement(By.Id("input_birthdate")).SendKeys("30101995");

            #region civilStatus
                IWebElement civilStatus = Driver.FindElement(By.Id("input_civil_status"));
                civilStatus.SendKeys("Married");
                civilStatus.SendKeys(Keys.Down);
                civilStatus.SendKeys(Keys.Enter);
            #endregion
           
            Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber);
            Driver.FindElement(By.Id("input_email")).SendKeys(randomFname + randomLname + "@gmail.com");

            #region gender
            IWebElement gender = Driver.FindElement(By.Id("input_gender"));
            gender.SendKeys("Male");
            gender.SendKeys(Keys.Down);
            gender.SendKeys(Keys.Enter);
            #endregion

            Driver.FindElement(By.Id("input_occupation")).SendKeys(randomOccupations);
            #region income
            IWebElement income = Driver.FindElement(By.Id("input_income"));
            income.SendKeys(randomIncome);
            income.SendKeys(Keys.Down);
            income.SendKeys(Keys.Enter);
            #endregion

            #region country
            IWebElement country = Driver.FindElement(By.Id("input_country"));
            System.Threading.Thread.Sleep(2000);
            country.Click();
            country.Clear();
            country.SendKeys(randomCountry);
            System.Threading.Thread.Sleep(3000);
            country.SendKeys(Keys.Down);
            country.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);
            #endregion

            #region province
            IWebElement province = Driver.FindElement(By.Id("input_province"));
            province.Click();
            province.SendKeys(Keys.Control + "a" + Keys.Delete);
            province.SendKeys("Argentina1");
            #endregion



            #region city
        
            IWebElement city = Driver.FindElement(By.Id("input_city"));
            city.Click();
            city.SendKeys(Keys.Control + "a" + Keys.Delete);
            city.SendKeys("Argentina2");
            #endregion

            #region subdivision
          
            IWebElement subdivision = Driver.FindElement(By.Id("input_subdivision"));
            subdivision.Click();
            subdivision.SendKeys(Keys.Control + "a" + Keys.Delete);
            subdivision.SendKeys("Olympic Village");
            #endregion

            #region street
            
            IWebElement street = Driver.FindElement(By.Id("input_street"));
            street.Click();
            street.SendKeys(Keys.Control + "a" + Keys.Delete);
            street.SendKeys("Fighter Street");
            #endregion

            #region buildingNumber
            IWebElement buildingNumber = Driver.FindElement(By.Id("input_building_number"));
            buildingNumber.Click();
            buildingNumber.SendKeys(Keys.Control + "a" + Keys.Delete);
            buildingNumber.SendKeys("12344");
            #endregion

            #region postalCode
            IWebElement postalCode = Driver.FindElement(By.Id("input_postal_code"));
            postalCode.Click();
            postalCode.SendKeys(Keys.Control + "a" + Keys.Delete);
            postalCode.SendKeys("2309");
            #endregion

            #region addCompanion
            //Driver.FindElement(By.Id("button_add_companion")).Click();
            //System.Threading.Thread.Sleep(5000);
            //Driver.FindElement(By.Id("input_salutation")).SendKeys("Mr");

            //Driver.FindElement(By.Id("input_first_name")).SendKeys("Jowie");

            //Driver.FindElement(By.Id("input_middle_name")).SendKeys("P");

            //Driver.FindElement(By.Id("input_last_name")).SendKeys("Jurado");

            //Driver.FindElement(By.Id("input_birthdate")).SendKeys("01101997");

            //Driver.FindElement(By.Id("input_civil_status")).SendKeys("Married");
            //Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Down);
            //Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Enter);

            //Driver.FindElement(By.Id("input_gender")).SendKeys("Male");
            //Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Down);
            //Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Enter);

            //Driver.FindElement(By.Id("input_occupation")).SendKeys("Manager");

            //Driver.FindElement(By.Id("input_income")).SendKeys("Php 50,000 Above");
            //Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Down);
            //Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Enter);
            //Driver.FindElement(By.Id("btn-retrieve-record")).Click();
            //System.Threading.Thread.Sleep(5000);
            #endregion

            Driver.FindElement(By.Id("button_next")).Click();

            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.ClassName("input_question_one_yes")).Click();
            Driver.FindElement(By.ClassName("input_question_two_no")).Click();
            Driver.FindElement(By.ClassName("input_question_three_yes")).Click();
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("button_submit")).Click();

            System.Threading.Thread.Sleep(500);

            //*[@id="app"]/div[1]
            //Driver.FindElement(By.XPath("//input[@id='app']/div[1]")).Click();

            IWebElement btnAction0 = Driver.FindElement(By.Id("btn-options-0"));
            btnAction0.Click();

            System.Threading.Thread.Sleep(3000);

            IWebElement btnOnboard0 = Driver.FindElement(By.Id("btn-onboard-0"));
            btnOnboard0.Click();

            










            




        }
    }
}