using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BookTrackerTest.StepDefinitions
{
    [Binding]
    public class NavigateStepDefinitions
    {
        IWebDriver webDriver = new ChromeDriver();
        string visit = "";
        [Given(@"the link to go to")]
        public void GivenTheLinkToGoTo()
        {
            visit = "https://localhost:3030/";
        }

        [Then(@"Navigate to the page")]
        public void ThenNavigateToThePage()
        {
            webDriver.Navigate().GoToUrl(visit);
            webDriver.Dispose();
        }
    }
}
