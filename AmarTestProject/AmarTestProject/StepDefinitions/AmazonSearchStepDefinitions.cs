using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AmarTestProject.StepDefinitions
{
    [Binding]
    public class AmazonSearchStepDefinitions
    {
        IWebDriver driver;

        [Given(@"I am amazon search")]
        public void GivenIAmAmazonSearch()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

        [When(@"I search for '([^']*)' in '([^']*)'s department")]
        public void WhenISearchForInSDepartment(string searchKey, string department)
        {


            //Find department dropdown
            var departmentDropdown = driver.FindElement(By.XPath("//*[@id='searchDropdownBox']"));
            //Select user input department
            SelectElement myFirstDropdownAutomaiton = new SelectElement(departmentDropdown);
            myFirstDropdownAutomaiton.SelectByText(department);

            //Dropdown automaiton
            //1. find select element using normal locator technique mechanism
            //2. create a SelectElement class object for the above element
            //3. perform the automaiton action using the object you created on SelectElement class

            //Find Search field
            var searchField = driver.FindElement(By.XPath("//*[@id='twotabsearchtextbox']"));
            //Enter your searchKey into search field
            searchField.SendKeys(searchKey);

            //Find search icon
            var searchIcon = driver.FindElement(By.XPath("//*[@id='nav-search-submit-button']"));
            //click on search icon
            searchIcon.Click();
        }


        [Then(@"I should the shoes in ""([^""]*)"" in results")]
        public void ThenIShouldTheShoesInInResults(string searchResultsKey)
        {
            var departmentInSearchResults = driver.FindElement(By.XPath($"//span[@class='a-list-item']/span[text() =\"{searchResultsKey}\"]"));
            Assert.IsTrue(departmentInSearchResults.Displayed, "Not able to find search key in results");
            driver.Quit();
        }

       
    }
}
