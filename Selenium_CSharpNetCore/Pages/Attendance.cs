using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharpNetCore.Pages
{
    internal class Attendance : DriverHelper
    {
        [SetUp]
        public void setUp()
        {
            Driver = new ChromeDriver();
        }
        [Test]
        public void Test()
        {

            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            Driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
            IWebElement userName = Driver.FindElement(By.Id("input-16"));
            userName.Click();
            userName.SendKeys(Keys.Control + "a" + Keys.Delete);
            userName.SendKeys("receptionist@revlv.com");
            //Driver.FindElement(By.Id("input-16")).SendKeys("admin@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.FindElement(By.LinkText("")).Click();
            //Driver.FindElement(By.XPath("//button[@class='v-btn__content']/following-sibling::div[text()='All']")).Click();

        }
    }
}
