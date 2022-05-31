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
            #region vars
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
            var randomRemarks = RandomGenerator.generateRemarks();
            var randomMembershipType = RandomGenerator.generateMembershipType();
            var randomRoomTypeRegular = RandomGenerator.generateRegularRoomType();
            var randomRoomTypePremium = RandomGenerator.generatePremiumRoomType();
            var randomHomeResort = RandomGenerator.generateHomeResort();
            var randomTerms = RandomGenerator.generateTerms();
            var randomDiscount = RandomGenerator.generateDiscount();
            var randomAdditionalDiscount = RandomGenerator.generateAdditionalDiscount();
            var randomPaymentMode = RandomGenerator.generatePaymentMode();
            var randomBank = RandomGenerator.generateBank();
            var randomAccountNum = RandomGenerator.generateAccountNum();
            var randomAmountPaid = RandomGenerator.generateAmountPaid();
            var randomDeposit = RandomGenerator.generateDeposit();
            var randomMaxOccupancy = RandomGenerator.generateMaximumOccupancy();
            var randomMonths = RandomGenerator.generateMonth();
            var randomOnboard = RandomGenerator.randomOnboardBtn();





            #endregion



            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");         
            Driver.Manage().Window.Maximize();
           
            Driver.FindElement(By.Id("input-16")).SendKeys("admin@revlv.com");
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

            #region Survey
           
            Driver.FindElement(By.Id("button_next")).Click();

            System.Threading.Thread.Sleep(2000);

            Driver.FindElement(By.ClassName("input_question_one_yes")).Click();
            Driver.FindElement(By.ClassName("input_question_two_no")).Click();
            Driver.FindElement(By.ClassName("input_question_three_yes")).Click();
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("button_submit")).Click();
            #endregion

            System.Threading.Thread.Sleep(5000);

            #region onboarding
            IWebElement btnAction0 = Driver.FindElement(By.Id("btn-options-"+ randomOnboard));
            btnAction0.Click();

            System.Threading.Thread.Sleep(3000);

            IWebElement btnOnboard0 = Driver.FindElement(By.Id("btn-onboard-" + randomOnboard ));
            btnOnboard0.Click();
            System.Threading.Thread.Sleep(5000);

            Driver.FindElement(By.Id("btn-add-email")).Click();
            Driver.FindElement(By.Id("input-email")).SendKeys(randomLname2 + randomMname + "@yahoo.com");
            //Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            Driver.FindElement(By.Id("btn-email-add")).Click();

            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("btn-add-social-media")).Click();
            Driver.FindElement(By.Id("input-name")).SendKeys(randomLname2 + " " + randomMname);
            Driver.FindElement(By.Id("input-account_name")).SendKeys(randomLname2 +" "+ randomMname);
            //Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            Driver.FindElement(By.Id("btn-social-add")).Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement membershipType = Driver.FindElement(By.Id("input-membership_type"));
            membershipType.SendKeys(randomMembershipType);
            membershipType.SendKeys(Keys.Down);
            membershipType.SendKeys(Keys.Enter);


            IWebElement homeResort = Driver.FindElement(By.Id("input-home_resort"));
            homeResort.SendKeys(randomHomeResort);
            homeResort.SendKeys(Keys.Down);
            homeResort.SendKeys(Keys.Enter);


            if (randomMembershipType == "Regular")
            {
                IWebElement regularMembership = Driver.FindElement(By.Id("input-room_type"));
                regularMembership.SendKeys(randomRoomTypeRegular);
                regularMembership.SendKeys(Keys.Down);
                regularMembership.SendKeys(Keys.Enter);
            }

            else
            {
                IWebElement premiumMembership = Driver.FindElement(By.Id("input-room_type"));
                premiumMembership.SendKeys(randomRoomTypePremium);
                premiumMembership.SendKeys(Keys.Down);
                premiumMembership.SendKeys(Keys.Enter);
            }
            System.Threading.Thread.Sleep(2000);
            IWebElement paymentTerms = Driver.FindElement(By.Id("input-payment_terms"));
            paymentTerms.Click();
            paymentTerms.SendKeys(randomTerms);
            System.Threading.Thread.Sleep(5000);
            paymentTerms.SendKeys(Keys.Down);
            paymentTerms.SendKeys(Keys.Enter);

            if(randomTerms == "Custom (# of mos)")
            {
                Driver.FindElement(By.Id("input-months")).SendKeys(randomMonths);
            }

            IWebElement discount = Driver.FindElement(By.Id("input-discount"));
            discount.SendKeys(randomDiscount);
            discount.SendKeys(Keys.Down);
            discount.SendKeys(Keys.Enter);

            //IWebElement additionalDiscount = Driver.FindElement(By.Id("input-additional_discount"));
            //additionalDiscount.SendKeys(randomAdditionalDiscount);
            //Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();


            IWebElement paymentMode = Driver.FindElement(By.Id("input-payment_mode"));
            paymentMode.SendKeys(randomPaymentMode);
            paymentMode.SendKeys(Keys.Down);
            paymentMode.SendKeys(Keys.Enter);

            if(randomPaymentMode== "Bank Transfer" || randomPaymentMode == "Credit Card" || randomPaymentMode == "Check/Cheque")
            {
                IWebElement bank = Driver.FindElement(By.Id("input-bank"));
                bank.SendKeys(randomBank);
                bank.SendKeys(Keys.Down);
                bank.SendKeys(Keys.Enter);

                Driver.FindElement(By.Id("input-account_number")).SendKeys(randomAccountNum);
            } 

            Driver.FindElement(By.Id("input-amount_paid")).SendKeys(randomAmountPaid);
            Driver.FindElement(By.Id("input-deposit")).SendKeys(randomDeposit);
            Driver.FindElement(By.Id("input-owner_relations_manager")).SendKeys(randomMname2 + " " + randomLname);
            Driver.FindElement(By.Id("input-max_occupancy_allowed")).SendKeys(randomMaxOccupancy);
            Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            Driver.FindElement(By.Id("btn-onboard")).Click();

            #endregion

        }
    }
}