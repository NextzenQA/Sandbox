using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiUnitTestProject.UI_Tests
{
    public class WebCalculatorValidation
    {

        [Test]
        public void ValidateMyWebCalculator() {
            string url = "https://www.desmos.com/scientific";

            //I want to validate multiple functionalities or requirements or scenarios or behaviours
            //all of them should start at some point (mostly launching the app)
            //all of them should end (mostly with application shut down)
            //all of them should work independently

            //to mark your functionalities as units
            //you will use for assertions


            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[@aria-label='2']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[@aria-label='Plus']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[@aria-label='5']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[@aria-label='Enter']")).Click();
            Thread.Sleep(1000);
            IWebElement result = driver.FindElement(By.XPath("//*[text()='2 plus 3 equals 5']"));

            Assert.IsNotNull(result);
        }

    }
}
