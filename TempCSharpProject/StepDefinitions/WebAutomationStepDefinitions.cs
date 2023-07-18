using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TempCSharpProject.Support;

namespace TempCSharpProject.StepDefinitions
{
    [Binding]
    public class WebAutomationStepDefinitions
    {
        [Given(@"I am on amazon search page")]
        public void GivenIAmOnAmazonSearchPage()
        {   /*
            Intern monica = new Intern();
            monica.Firstname = "Monica";
            monica.Lastname = "something";
            monica.GetTheBackground();

            Intern pavan = new Intern();
            pavan.Firstname = "Pavan";
            pavan.Lastname = "something";
            pavan.GetTheBackground();
            

            Console.WriteLine(Intern.InternshipRole);
            
            //Method Chaining
            MethodChaining chaining = new MethodChaining();
            chaining.Method1().Method3();
            */


            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();

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
