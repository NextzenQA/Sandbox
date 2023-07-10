using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Fundementals
{
    public class TrainingOnC_
    {

        public static void Main()
        {


            //do I have selenium support ? Have you added ?
            //dependencies - SeleniumWebdriver, chromedriver

            //ChromeDriver - is a class wich has the ability to automate chrome browser

            //to acess the methods you need to create object

            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://www.google.com");
            chromeDriver.Manage().Window.Maximize();

            //ChromeDriver - for launching, navigating, maximizing, closing, to find an element (By- locator technique as input)
            //By - to use locator technique
            //IWebEelement - to perform an action on element

            //How to find an element
            //Where is it - it is on chromedriver

            //Specficy the locator string
            string xPathForSearchField = "//*[@title='Search']";

            //Specify the locator technique
            //you can access static nethods with out object
            By locatorTechnique = By.XPath(xPathForSearchField);

            //Find the element using locator technique
            //simple integers
            IWebElement searchBox = chromeDriver.FindElement(locatorTechnique);

            //perform an action on the element
            searchBox.SendKeys("Nextzen");

            //this is oneliner for everything
            //chromeDriver.FindElement(By.XPath("//textarea[@title='Search']")).SendKeys("Nextzen");

            Thread.Sleep(2000);
            //Click onsearch
            string xpathForSearchButton = "//div[2]//input[@value='Google Search']";
            By locatorTechniqueForSearchField = By.XPath(xpathForSearchButton);
            IWebElement searchButton = chromeDriver.FindElement(locatorTechniqueForSearchField);
            searchButton.Click();



            //TO DO: Click on first link in the search outputs
            //Write xpath
            //use locator technilique like line 58
            //store element like line 59
            //click like line 60





            //chromeDriver.Quit();

        }


       


    }
}
