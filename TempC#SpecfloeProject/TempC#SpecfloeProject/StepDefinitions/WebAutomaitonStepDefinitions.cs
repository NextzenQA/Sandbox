using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TempCSpecfloeProject.Support;

namespace TempCSpecfloeProject.StepDefinitions
{
    [Binding]
    public class WebAutomaitonStepDefinitions
    {
        [Given(@"I am on amazon search page")]
        public void GivenIAmOnAmazonSearchPage()
        {
            /*Intern monica = new Intern();
            monica.Firstname = "Monica";
            monica.Lastname = "somehyin";
            monica.GetTheBackground();

            Intern pavan = new Intern();
            pavan.Firstname = "Pavan";
            pavan.Lastname = "somehyin else";
            pavan.GetTheBackground();

            Console.WriteLine(Intern.PrintHisRole);*/


            Console.WriteLine(Intern.IntershipRole);

            //MethodChaining chaining = new MethodChaining();
            //Method 1 is returning the same object which has method 1,2,3
            //chaining.Method1().Method3();
            //chaining.Method1().intern.GetTheBackground();


            ChromeDriver driver = new ChromeDriver();
            //method chaining
            //Navigate is a method on WebDriver
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(30000);
        }

        [When(@"I search for electronics")]
        public void WhenISearchForElectronics()
        {
            
        }

        [Then(@"I should see electronics results")]
        public void ThenIShouldSeeElectronicsResults()
        {
            
        }
    }
}
