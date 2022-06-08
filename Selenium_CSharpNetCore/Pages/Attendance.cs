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
          
            IWebElement userName = Driver.FindElement(By.Id("input-16"));
            userName.Click();
            userName.SendKeys(Keys.Control + "a" + Keys.Delete);
            userName.SendKeys("receptionist@revlv.com");
            //Driver.FindElement(By.Id("input-16")).SendKeys("admin@revlv.com");
            //Driver.FindElement(By.Id("input-20")).SendKeys("password");
            Driver.FindElement(By.ClassName("v-btn__content")).Click();
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            System.Threading.Thread.Sleep(3000);

            Driver.FindElement(By.Id("btn-attendance-sort")).Click();
            Driver.FindElement(By.Id("btn-attendance-sort-pending")).Click();
            for (int i = 0; i < 5; i++)
            {
      
                System.Threading.Thread.Sleep(500);
                Driver.FindElement(By.Id("btn-options-0")).Click();
                System.Threading.Thread.Sleep(2000);
                Driver.FindElement(By.Id("btn-onboard-0")).Click();
                System.Threading.Thread.Sleep(500);
                IWebElement dateAttended = Driver.FindElement(By.Id("input-attended_at"));
                dateAttended.Click();
                dateAttended.SendKeys("06072022");
                Driver.FindElement(By.Id("btn-save")).Click();
                
            }
        }
    }
}
