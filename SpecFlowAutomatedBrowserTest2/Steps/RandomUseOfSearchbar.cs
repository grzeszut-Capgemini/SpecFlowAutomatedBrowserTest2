using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowAutomatedBrowserTest2.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowAutomatedBrowserTest2.Steps
{
    [Binding]
    public class RandomUseOfSearchbar
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public RandomUseOfSearchbar(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to http://google\.com on following enviromentt")]
        public void GivenINavigateToHttpGoogle_ComOnFollowingEnviromentt(Table table)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("http://google.com");
            driver.FindElement(By.XPath("//div[text()='Zgadzam się']")).Click();
        }
        
        [Given(@"And i click into searchbar")]
        public void GivenAndIClickIntoSearchbar()
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            
        }
        
        [When(@"I put random text into searchbar and submit")]
        public void WhenIPutRandomTextIntoSearchbarAndSubmit()
        {
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("random text");
            driver.FindElement(By.XPath("//input[@type='text']")).Submit();
        }
        
        [Then(@"I get random result of search")]
        public void ThenIGetRandomResultOfSearch()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@id='result-stats']")).Displayed);
        }
    }
}
