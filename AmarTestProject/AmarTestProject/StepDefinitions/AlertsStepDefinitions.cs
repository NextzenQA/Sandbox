using AmarTestProject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AmarTestProject.StepDefinitions
{
    [Binding]
    public class AlertsStepDefinitions
    {



        [Given(@"I am on cher cher practice popups page")]
        public void GivenIAmOnCherCherPracticePopupsPage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl("https://chercher.tech/practice/practice-pop-ups-selenium-webdriver");
        }

        [When(@"I bring an alert")]
        public void WhenIBringAnAlert()
        {
            var alertButton = ObjectRepository.Driver.FindElement(By.Name("alert"));
            alertButton.Click();    
        }

        [Then(@"I should be able to accept the alert")]
        public void ThenIShouldBeAbleToAcceptTheAlert()
        {
            var alert = ObjectRepository.Driver.SwitchTo().Alert();
            //Frames
            Console.WriteLine(alert.Text);
            //Child Windows
            alert.Accept();
        }

        [When(@"I bring a confirmation")]
        public void WhenIBringAConfirmation()
        {
            var confirmationButton = ObjectRepository.Driver.FindElement(By.Name("confirmation"));
            confirmationButton.Click();
        }

        [Then(@"I should be able to accept the confirmation")]
        public void ThenIShouldBeAbleToAcceptTheConfirmation()
        {
            var alert = ObjectRepository.Driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();
        }

        [Then(@"I should be able to decline the confirmation")]
        public void ThenIShouldBeAbleToDeclineTheConfirmation()
        {
            var alert = ObjectRepository.Driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();
        }

        [When(@"I bring a prompt")]
        public void WhenIBringAPrompt()
        {
            var promptButton = ObjectRepository.Driver.FindElement(By.XPath("//*[@name='prompt']"));
            promptButton.Click();
        }

        [Then(@"I should be able to accept the prompt with a message")]
        public void ThenIShouldBeAbleToAcceptThePromptWithAMessage()
        {
            var alert = ObjectRepository.Driver.SwitchTo().Alert();
            alert.SendKeys("Sai");
            Console.WriteLine(alert.Text);
            alert.Accept();
        }

        [Then(@"I should be able to decline the prompt with a message")]
        public void ThenIShouldBeAbleToDeclineThePromptWithAMessage()
        {
            var alert = ObjectRepository.Driver.SwitchTo().Alert();
            alert.SendKeys("Sai");
            Console.WriteLine(alert.Text);
            alert.Dismiss();
        }
    }
}
