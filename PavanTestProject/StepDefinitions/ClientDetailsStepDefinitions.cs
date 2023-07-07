

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PavanTestProject.StepDefinitions
{
    [Binding]
    public class ClientDetailsStepDefinitions
    {
        [Given(@"I am on Nextzen client details page")]
        public void GivenIAmOnNextzenClientDetailsPage()
        {
            //Launch chrome browser
            ChromeDriver ganesh = new ChromeDriver();
            //Go to nextzen url
            ganesh.Navigate().GoToUrl("http://18.218.168.29/NextzenHome.html");
            //Implicit wait
            ganesh.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Hard wait
            //Thread.Sleep(5000);


            //go to colors ifrmae
            var color = ganesh.FindElement(By.XPath("//iframe[@src='Header.html']"));

            //switch ganesh to color
            ganesh.SwitchTo().Frame(color);

            //Go to client details page
            var sai = ganesh.FindElement(By.XPath("//a[@href='ClientDetails.html']"));
            sai.Click();


        }

        [When(@"I submit client details with all required fields")]
        public void WhenISubmitClientDetailsWithAllRequiredFields()
        {
            //submit client details with required fields
        }

        [Then(@"I should see a successful submission message")]
        public void ThenIShouldSeeASuccessfulSubmissionMessage()
        {
            //Make sure we see a successs message
        }

        [When(@"I submit client details without all required fields")]
        public void WhenISubmitClientDetailsWithoutAllRequiredFields()
        {
            //submit client details without required fields
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            //Make sure we see a error message
        }
    }
}
