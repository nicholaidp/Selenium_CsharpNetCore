using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_CSharpNetCore
{
    internal class testesting : DriverHelper
    {
        [Test]
       public void test223()

        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://112.199.116.13:3001/login");
            IWebElement testText = Driver.FindElement(By.ClassName("v-btn__content"));
            string testType = testText.Text;
            Driver.FindElement(By.Id("input-16")).SendKeys(testType);
            
        }
    }
}
