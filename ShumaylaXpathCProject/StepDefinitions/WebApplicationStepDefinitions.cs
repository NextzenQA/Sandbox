using OpenQA.Selenium.Chrome;
using System;
using ShumaylaCProject.Support;
using TechTalk.SpecFlow;

namespace ShumaylaCProject.StepDefinitions
{
    [Binding]
    public class WebApplicationStepDefinitions
    {
        [Given(@"I am on amazon search page")]
        public void GivenIAmOnAmazonSearchPage()
        {
            /* intern Shumayla = new intern();
              Shumayla.Firstname = "Shumayla";
              Shumayla.Lastname = "Saify";
              Shumayla.GetTheBackground(); */
            
              //Console.WriteLine(intern.InternshipRole); 

            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");

            MethodChaining chaining = new MethodChaining();               
            driver.Manage().Window.Maximize();

            //MethodChaining chaining = new MethodChaining();
            //chaining.Method1().Method3();
        
        }

        [When(@"I search for cosmatics")]
        public void WhenISearchForCosmatics()
        {

        }
            [Then(@"I should see results for cosmatics")]
            public void ThenIShouldSeeResultsForCosmatics()

        {

        }

    }
}
