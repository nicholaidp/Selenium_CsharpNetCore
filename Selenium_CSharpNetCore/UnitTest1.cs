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
            //Driver.Navigate().GoToUrl("http://localhost/attendance");
            //Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            //Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
           
            Driver.FindElement(By.Id("input-16")).SendKeys("kslimlengco@revlv.com");
            Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.LinkText("NEW")).Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.FindElement(By.Id("input_salutation")).SendKeys("Engineer");

            Driver.FindElement(By.Id("input_first_name")).SendKeys("Karl");

            Driver.FindElement(By.Id("input_middle_name")).SendKeys("S");

            Driver.FindElement(By.Id("input_last_name")).SendKeys("Limlengco");

            Driver.FindElement(By.Id("input_birthdate")).SendKeys("30101995");

            Driver.FindElement(By.Id("input_civil_status")).SendKeys("Married");
            Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("input_gender")).SendKeys("Male");
            Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("input_occupation")).SendKeys("Engineer");

            Driver.FindElement(By.Id("input_income")).SendKeys("Php 40,000 - Php 49,999");
            Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("input_country")).Click();
            Driver.FindElement(By.Id("input_country")).Clear();
            Driver.FindElement(By.Id("input_country")).SendKeys("Argentina");
            System.Threading.Thread.Sleep(2000);
            Driver.FindElement(By.Id("input_country")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_country")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(1000);
            Driver.FindElement(By.Id("input_province")).Click();
            Driver.FindElement(By.Id("input_province")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_province")).SendKeys("Argentina1");


       
            Driver.FindElement(By.Id("input_city")).Click();
            Driver.FindElement(By.Id("input_city")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_city")).SendKeys("Argentina2");

            Driver.FindElement(By.Id("input_subdivision")).Click();
            Driver.FindElement(By.Id("input_subdivision")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_subdivision")).SendKeys("Olympic Village");

            Driver.FindElement(By.Id("input_street")).Click();
            Driver.FindElement(By.Id("input_street")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_street")).SendKeys("Fighter Street");

            Driver.FindElement(By.Id("input_building_number")).Click();
            Driver.FindElement(By.Id("input_building_number")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_building_number")).SendKeys("12344");

            Driver.FindElement(By.Id("input_postal_code")).Click();
            Driver.FindElement(By.Id("input_postal_code")).SendKeys(Keys.Control + "a" + Keys.Delete);
            Driver.FindElement(By.Id("input_postal_code")).SendKeys("2309");
            Driver.FindElement(By.Id("button_add_companion")).Click();











            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Id("input_salutation")).SendKeys("Mr");

            Driver.FindElement(By.Id("input_first_name")).SendKeys("Jowie");

            Driver.FindElement(By.Id("input_middle_name")).SendKeys("P");

            Driver.FindElement(By.Id("input_last_name")).SendKeys("Jurado");

            Driver.FindElement(By.Id("input_birthdate")).SendKeys("01101997");

            Driver.FindElement(By.Id("input_civil_status")).SendKeys("Married");
            Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_civil_status")).SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("input_gender")).SendKeys("Male");
            Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_gender")).SendKeys(Keys.Enter);

            Driver.FindElement(By.Id("input_occupation")).SendKeys("Manager");

            Driver.FindElement(By.Id("input_income")).SendKeys("Php 50,000 Above");
            Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Down);
            Driver.FindElement(By.Id("input_income")).SendKeys(Keys.Enter);
            Driver.FindElement(By.Id("btn-retrieve-record")).Click();
            System.Threading.Thread.Sleep(5000);

            Driver.FindElement(By.Id("button_next")).Click();

            System.Threading.Thread.Sleep(5000);
             Driver.FindElement(By.Id("input-261")).Click();


            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);






            //Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();


            //CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");




        }
    }
}