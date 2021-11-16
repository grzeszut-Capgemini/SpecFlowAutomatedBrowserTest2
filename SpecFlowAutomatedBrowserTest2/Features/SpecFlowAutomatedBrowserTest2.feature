Feature: SpecFlowAutomatedBrowserTest2
	Testing random web pages

@GoogleSearchBar
Scenario: Look for the Searchbar - chrome
	Given I navigate to http://google.com on following enviroment
		| Browser | BrowserVersion | OS         |
		| Chrome  | 96.0.4664.45   | Windows 10 |
	When Page is loaded
	Then Searchbar should be Displayed