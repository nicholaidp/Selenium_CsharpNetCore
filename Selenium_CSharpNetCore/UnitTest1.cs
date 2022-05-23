using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/")
            ;
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

          
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");




            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}