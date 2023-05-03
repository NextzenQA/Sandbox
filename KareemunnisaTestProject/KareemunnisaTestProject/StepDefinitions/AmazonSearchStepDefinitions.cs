using System;
using TechTalk.SpecFlow;

namespace KareemunnisaTestProject.StepDefinitions
{
    [Binding]
    public class AmazonSearchStepDefinitions
    {
        [When(@"'([^']*)' searches for '([^']*)'")]
        public void WhenSearchesFor(string krishna, string accounts)
        {
            throw new PendingStepException();
        }
    }
}
