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
            int loopCounter = 17;

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


                System.Threading.Thread.Sleep(1000);

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();
                System.Threading.Thread.Sleep(2000);
                IWebElement exhibitDate = Driver.FindElement(By.Id("input_exhibit_date"));
                exhibitDate.SendKeys(Keys.Control + "a" + Keys.Delete);
                exhibitDate.SendKeys("06/16/2022");
                Driver.FindElement(By.Id("input_exhibit_time")).SendKeys("1029PM");
                Driver.FindElement(By.Id("input_salutation")).SendKeys(randomSalutations);
                Driver.FindElement(By.Id("input_first_name")).SendKeys(randomFname);
                Driver.FindElement(By.Id("input_middle_name")).SendKeys(randomMname);
                Driver.FindElement(By.Id("input_last_name")).SendKeys(randomLname);

                IWebElement txtSource = Driver.FindElement(By.Id("input_source"));
                txtSource.SendKeys(randomSource);
                txtSource.SendKeys(Keys.Down);
                txtSource.SendKeys(Keys.Enter);
                IWebElement txtSourceRemarks = Driver.FindElement(By.Id("input-source-remark"));
                txtSourceRemarks.SendKeys("Test");
                txtSourceRemarks.SendKeys(Keys.Down);
                txtSourceRemarks.SendKeys(Keys.Enter);
                IWebElement txtVM = Driver.FindElement(By.Id("input-vm"));
                txtVM.Click();
                txtVM.SendKeys("Jay Fernandez");
                txtVM.SendKeys(Keys.Down);
                txtVM.SendKeys(Keys.Enter);
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
                //IWebElement txtSubdivision = Driver.FindElement(By.Id("input_subdivision"));
                //txtSubdivision.SendKeys(randomSubdivision);
                //IWebElement txtStreet = Driver.FindElement(By.Id("input_street"));
                //txtStreet.SendKeys(randomStreet);
                //IWebElement txtBuildingNum = Driver.FindElement(By.Id("input_building_number"));
                //txtBuildingNum.SendKeys(randomBuildingnum);
                //IWebElement txtPostalc = Driver.FindElement(By.Id("input_postal_code"));
                //txtPostalc.SendKeys(randomPostalCode);

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
                IWebElement btnSave = Driver.FindElement(By.Id("button_save"));
                Driver.FindElement(By.Id("input_spouse_occupation")).SendKeys(randomspouseOccupation);
                Driver.FindElement(By.Id("input_stub_number")).SendKeys(randomstubNum);
                btnSave.Click();
                //System.Threading.Thread.Sleep(10000);
            }

            IWebElement btnAvatar = Driver.FindElement(By.ClassName("v-avatar"));
            btnAvatar.Click();  
            IWebElement btnLogout = Driver.FindElement(By.Id("btn-logout"));
            btnLogout.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement txtUsername2 = Driver.FindElement(By.Id("input-username"));
            txtUsername2.Clear();
            txtUsername2.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername2.SendKeys("exhibitoradmin@revlv.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            IWebElement btnLogin = Driver.FindElement(By.ClassName("v-btn__content"));
            btnLogin.Click();

           
            for (int i = 0; i < loopCounter; i++)
            {
                Driver.FindElement(By.Id("btn-attendance-sort")).Click();
                Driver.FindElement(By.Id("btn-attendance-sort-pending")).Click();
                System.Threading.Thread.Sleep(3000);
                Driver.FindElement(By.Id("btn-options-0")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.FindElement(By.Id("btn-onboard-0")).Click();
                System.Threading.Thread.Sleep(500);
                IWebElement dateAttended = Driver.FindElement(By.Id("input-attended_at"));
                dateAttended.Click();
                dateAttended.SendKeys("21062022");
                Driver.FindElement(By.Id("btn-save")).Click();

            }
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
          
            IWebElement btnAvatar2 = Driver.FindElement(By.ClassName("v-avatar"));
            btnAvatar2.Click();  
            IWebElement btnLogout2 = Driver.FindElement(By.Id("btn-logout"));
            btnLogout2.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement txtUsername3 = Driver.FindElement(By.Id("input-username"));
            txtUsername3.SendKeys(Keys.Control + "a" + Keys.Delete);
            txtUsername3.SendKeys("tableofficer@revlv.com");
            IWebElement btnLogin2 = Driver.FindElement(By.ClassName("v-btn__content"));
            btnLogin2.Click();
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.Id("btn-qualification")).Click();
            Driver.FindElement(By.Id("btn-qualification-pending")).Click();

            for(int i = 0; i < loopCounter; i++)
            {
                randomOccupations = RandomGenerator.generateOccupation();
                randomCountry = RandomGenerator.generateCountry();
                randomProvince = RandomGenerator.generateProvince();
                randomCity = RandomGenerator.generateCity();

                Driver.FindElement(By.Id("btn-options-0")).Click();
                Driver.FindElement(By.Id("btn-update-0")).Click();
                Driver.FindElement(By.Id("input_occupation")).SendKeys(randomOccupations);
                IWebElement country = Driver.FindElement(By.Id("input_country"));
                country.Click();
                country.SendKeys(Keys.Control + "a" + Keys.Delete);
                country.SendKeys(randomCountry);
                System.Threading.Thread.Sleep(4000);
                country.SendKeys(Keys.Down);
                country.SendKeys(Keys.Enter);

                IWebElement province = Driver.FindElement(By.Id("input_province"));
                province.Click();
                province.SendKeys(Keys.Control + "a" + Keys.Delete);
                province.SendKeys(randomProvince);

                IWebElement city = Driver.FindElement(By.Id("input_province"));
                city.Click();
                city.SendKeys(Keys.Control + "a" + Keys.Delete);
                city.SendKeys(randomCity);
                Driver.FindElement(By.Id("button_next")).Click();


                #region Survey

                Driver.FindElement(By.Id("button_next")).Click();

                System.Threading.Thread.Sleep(2000);

                Driver.FindElement(By.ClassName("input_question_one_yes")).Click();
                Driver.FindElement(By.ClassName("input_question_two_no")).Click();
                Driver.FindElement(By.ClassName("input_question_three_yes")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.FindElement(By.Id("button_submit")).Click();
                #endregion
            }
            #region comments



            //System.Threading.Thread.Sleep(5000);

            //#region onboarding
            // IWebElement btnAction0 = Driver.FindElement(By.Id("btn-options-"+ randomOnboard));
            //btnAction0.Click();

            //System.Threading.Thread.Sleep(3000);

            //IWebElement btnOnboard0 = Driver.FindElement(By.Id("btn-onboard-" + randomOnboard ));
            //btnOnboard0.Click();
            //System.Threading.Thread.Sleep(5000);

            //Driver.FindElement(By.Id("btn-add-email")).Click();
            //Driver.FindElement(By.Id("input-email")).SendKeys(randomLname2 + randomMname + "@yahoo.com");
            ////Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            //Driver.FindElement(By.Id("btn-email-add")).Click();

            //System.Threading.Thread.Sleep(2000);
            //Driver.FindElement(By.Id("btn-add-social-media")).Click();
            //Driver.FindElement(By.Id("input-name")).SendKeys(randomLname2 + " " + randomMname);
            //Driver.FindElement(By.Id("input-account_name")).SendKeys(randomLname2 +" "+ randomMname);
            ////Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            //Driver.FindElement(By.Id("btn-social-add")).Click();

            //System.Threading.Thread.Sleep(2000);
            //IWebElement membershipType = Driver.FindElement(By.Id("input-membership_type"));
            //membershipType.SendKeys(randomMembershipType);
            //membershipType.SendKeys(Keys.Down);
            //membershipType.SendKeys(Keys.Enter);


            //IWebElement homeResort = Driver.FindElement(By.Id("input-home_resort"));
            //homeResort.SendKeys(randomHomeResort);
            //homeResort.SendKeys(Keys.Down);
            //homeResort.SendKeys(Keys.Enter);


            //if (randomMembershipType == "Regular")
            //{
            //    IWebElement regularMembership = Driver.FindElement(By.Id("input-room_type"));
            //    regularMembership.SendKeys(randomRoomTypeRegular);
            //    regularMembership.SendKeys(Keys.Down);
            //    regularMembership.SendKeys(Keys.Enter);
            //}

            //else
            //{
            //    IWebElement premiumMembership = Driver.FindElement(By.Id("input-room_type"));
            //    premiumMembership.SendKeys(randomRoomTypePremium);
            //    premiumMembership.SendKeys(Keys.Down);
            //    premiumMembership.SendKeys(Keys.Enter);
            //}
            //System.Threading.Thread.Sleep(2000);
            //IWebElement paymentTerms = Driver.FindElement(By.Id("input-payment_terms"));
            //paymentTerms.Click();
            //paymentTerms.SendKeys(randomTerms);
            //System.Threading.Thread.Sleep(5000);
            //paymentTerms.SendKeys(Keys.Down);
            //paymentTerms.SendKeys(Keys.Enter);

            //if(randomTerms == "Custom (# of mos)")
            //{
            //    Driver.FindElement(By.Id("input-months")).SendKeys(randomMonths);
            //}

            //IWebElement discount = Driver.FindElement(By.Id("input-discount"));
            //discount.SendKeys(randomDiscount);
            //discount.SendKeys(Keys.Down);
            //discount.SendKeys(Keys.Enter);

            ////IWebElement additionalDiscount = Driver.FindElement(By.Id("input-additional_discount"));
            ////additionalDiscount.SendKeys(randomAdditionalDiscount);
            ////Driver.FindElement(By.ClassName("v-btn--is-elevated")).Click();


            //IWebElement paymentMode = Driver.FindElement(By.Id("input-payment_mode"));
            //paymentMode.SendKeys(randomPaymentMode);
            //paymentMode.SendKeys(Keys.Down);
            //paymentMode.SendKeys(Keys.Enter);

            //if(randomPaymentMode== "Bank Transfer" || randomPaymentMode == "Credit Card" || randomPaymentMode == "Check/Cheque")
            //{
            //    IWebElement bank = Driver.FindElement(By.Id("input-bank"));
            //    bank.SendKeys(randomBank);
            //    bank.SendKeys(Keys.Down);
            //    bank.SendKeys(Keys.Enter);

            //    Driver.FindElement(By.Id("input-account_number")).SendKeys(randomAccountNum);
            //} 

            //Driver.FindElement(By.Id("input-amount_paid")).SendKeys(randomAmountPaid);
            //Driver.FindElement(By.Id("input-deposit")).SendKeys(randomDeposit);
            //Driver.FindElement(By.Id("input-owner_relations_manager")).SendKeys(randomMname2 + " " + randomLname);
            //Driver.FindElement(By.Id("input-max_occupancy_allowed")).SendKeys(randomMaxOccupancy);
            //Driver.FindElement(By.Id("input-remarks")).SendKeys(randomRemarks);
            //Driver.FindElement(By.Id("btn-onboard")).Click();

            //#endregion
            #endregion

        }
    }
}