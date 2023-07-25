
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ShumaylaSeleniumTestProject.StepDefinitions
{
    [Binding]
    public class FilloutFormsStepDefinitions
    {
        IWebDriver driver;

        [Given(@"I am on fill out form page of ultimate QA application")]
        public void GivenIAmOnFillOutFormPageOfUltimateQAApplication()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
        }

        [When(@"I submit a message")]
        public void WhenISubmitAMessage()
        {
            IWebElement nameField = driver.FindElement(By.XPath("//input[@id='et_pb_contact_name_0']"));
            nameField.SendKeys("Shumayla");

            IWebElement CommentField = driver.FindElement(By.XPath("//textarea[@id='et_pb_contact_message_0']"));
            CommentField.SendKeys("This is Shumayla");

            IWebElement submitBtn = driver.FindElement(By.XPath("//button[@name='et_builder_submit_button']"));
            submitBtn.Click();
        }

        [Then(@"I should see '([^']*)' message )]
        public void ThenIShouldSeeTheMessage(string successMessageText)
        {
            IWebElement successMessage = driver.FindElement(By.XPath(""//*[text()='Thanks for contacting us']""));
            Assert.AreEqual(successMessageText, successMessage.Text);
        }
    }
}
