using AmarTestProject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AmarTestProject.Hooks
{
    [Binding]
    public sealed class ScenarioHookscs
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            ObjectRepository.Driver = new ChromeDriver();
            //Implicit Wait imlimentation
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ObjectRepository.Driver.Quit();
        }
    }
}