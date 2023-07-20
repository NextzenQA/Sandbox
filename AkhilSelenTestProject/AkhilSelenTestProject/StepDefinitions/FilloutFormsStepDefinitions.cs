using System;
using TechTalk.SpecFlow;

namespace AkhilSelenTestProject.StepDefinitions
{
    [Binding]
    public class FilloutFormsStepDefinitions
    {
        [Given(@"I am on fill out forms page of Ultimate QA application")]
        public void GivenIAmOnFillOutFormsPageOfUltimateQAApplication()
        {
            throw new PendingStepException();
        }

        [When(@"I submit a message")]
        public void WhenISubmitAMessage()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see '([^']*)' message")]
        public void ThenIShouldSeeMessage(string p0)
        {
            throw new PendingStepException();
        }
    }
}
