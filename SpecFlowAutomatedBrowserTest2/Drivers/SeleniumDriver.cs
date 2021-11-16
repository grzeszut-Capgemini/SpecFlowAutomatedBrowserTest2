using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowAutomatedBrowserTest2.Drivers
{
	public class SeleniumDriver
	{
		private IWebDriver driver;
		private readonly ScenarioContext _scenarioContext;

		public SeleniumDriver(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		public IWebDriver Setup()
		{
			var chromeOptions = new ChromeOptions(); // zbedne ?

			driver = new ChromeDriver();

			_scenarioContext.Set(driver, "WebDriver");

			driver.Manage().Window.Maximize();

			return driver;
		}
	}
}
 