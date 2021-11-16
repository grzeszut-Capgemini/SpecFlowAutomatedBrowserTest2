using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowAutomatedBrowserTest2.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowAutomatedBrowserTest2.Steps
{
	[Binding]
	public sealed class BrowserStepDefinition
	{
        IWebDriver driver;

		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;

		public BrowserStepDefinition(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

        [Given(@"I navigate to http://google\.com on following enviroment")]
        public void GivenINavigateToHttpGoogle_ComOnFollowingEnviroment(Table table)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("http://google.com");
            //driver.Url = "http://google.com";
        }

        [When(@"Page is loaded")]
        public void WhenPageIsLoaded()
        {
            //Thread.Sleep(5000);
        }

        [Then(@"Searchbar should be Displayed")]
        public void ThenSearchbarShouldBeDisplayed()
        {
            Assert.IsTrue((driver.FindElement(By.XPath("//input[@type='text']"))).Displayed);
          
        }

    }
}
