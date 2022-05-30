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
            var randomCity = RandomGenerator.generateCity();
            var randomProvince = RandomGenerator.generateProvince();
            var randomStreet = RandomGenerator.generateStreet();
            var randomBuildingNum = RandomGenerator.generateBuildingNum();
            var randomSubdivision = RandomGenerator.generateSubdivision();
            var randomPostalCode = RandomGenerator.generatePostalCode();
            var randomDOB = RandomGenerator.generateDOB();
            var randomDOB2 = RandomGenerator.generateDOB();
            var randomCivilStatus = RandomGenerator.generateCivilStatus();
            var randomCivilStatus2 = RandomGenerator.generateCivilStatus();
            var randomFname2 = RandomGenerator.generateFname();
            var randomLname2 = RandomGenerator.generateLname();
            var randomMname2 = RandomGenerator.generateMname();
            var randomSalutations2 = RandomGenerator.generateSalutation();
            var randomPhonenumber2 = RandomGenerator.generatePhonenumber();
            var randomOccupations2 = RandomGenerator.generateOccupation();
            var randomIncome2 = RandomGenerator.generateIncome();

           

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

            Driver.FindElement(By.Id("input_birthdate")).SendKeys(randomDOB);

            #region civilStatus
                IWebElement civilStatus = Driver.FindElement(By.Id("input_civil_status"));
                civilStatus.SendKeys(randomCivilStatus);
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
            province.SendKeys(randomProvince);
            #endregion



            #region city
        
            IWebElement city = Driver.FindElement(By.Id("input_city"));
            city.Click();
            city.SendKeys(Keys.Control + "a" + Keys.Delete);
            city.SendKeys(randomCity);
            #endregion

            #region subdivision
          
            IWebElement subdivision = Driver.FindElement(By.Id("input_subdivision"));
            subdivision.Click();
            subdivision.SendKeys(Keys.Control + "a" + Keys.Delete);
            subdivision.SendKeys(randomSubdivision);
            #endregion

            #region street
            
            IWebElement street = Driver.FindElement(By.Id("input_street"));
            street.Click();
            street.SendKeys(Keys.Control + "a" + Keys.Delete);
            street.SendKeys(randomStreet);
            #endregion

            #region buildingNumber
            IWebElement buildingNumber = Driver.FindElement(By.Id("input_building_number"));
            buildingNumber.Click();
            buildingNumber.SendKeys(Keys.Control + "a" + Keys.Delete);
            buildingNumber.SendKeys(randomBuildingNum);
            #endregion

            #region postalCode
            IWebElement postalCode = Driver.FindElement(By.Id("input_postal_code"));
            postalCode.Click();
            postalCode.SendKeys(Keys.Control + "a" + Keys.Delete);
            postalCode.SendKeys(randomPostalCode);
            #endregion

            #region addCompanion
            Driver.FindElement(By.Id("button_add_companion")).Click();
            Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations2);
            Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname2);
            Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname2);

            Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname2);

            Driver.FindElement(By.Id("input_birthdate")).SendKeys(randomDOB2);

            #region civilStatus
           
            civilStatus.SendKeys(randomCivilStatus2);
            civilStatus.SendKeys(Keys.Down);
            civilStatus.SendKeys(Keys.Enter);
            #endregion

            Driver.FindElement(By.Id("input_contact_number")).SendKeys("09" + randomPhonenumber2);
            Driver.FindElement(By.Id("input_email")).SendKeys(randomFname2 + randomLname2 + "@gmail.com");

            #region gender
           
            gender.SendKeys("Male");
            gender.SendKeys(Keys.Down);
            gender.SendKeys(Keys.Enter);
            #endregion

            Driver.FindElement(By.Id("input_occupation")).SendKeys(randomOccupations2);
            #region income
            
            income.SendKeys(randomIncome2);
            income.SendKeys(Keys.Down);
            income.SendKeys(Keys.Enter);
            #endregion

            Driver.FindElement(By.Id("btn-retrieve-record")).Click();

            System.Threading.Thread.Sleep(1000);
            #endregion

            Driver.FindElement(By.Id("button_next")).Click();

            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.ClassName("input_question_one_yes")).Click();
            Driver.FindElement(By.ClassName("input_question_two_no")).Click();
            Driver.FindElement(By.ClassName("input_question_three_yes")).Click();

            Driver.FindElement(By.XPath("//*[@id='input_proceed_onboarding']/div/main/div/div/div[2]/div/div/div[2]/div[2]/form/div[5]/div/div/div/div[1]/div/div")).Click();

            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("button_submit")).Click();

            System.Threading.Thread.Sleep(500);


            IWebElement btnAction0 = Driver.FindElement(By.Id("btn-options-0"));
            btnAction0.Click();

            System.Threading.Thread.Sleep(3000);

            IWebElement btnOnboard0 = Driver.FindElement(By.Id("btn-onboard-0"));
            btnOnboard0.Click();

            










            




        }
    }
}