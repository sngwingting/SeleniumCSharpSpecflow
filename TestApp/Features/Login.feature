Feature: Registration

Registration flow: user registers from the website header

@tag1
Scenario: Login
	Given User is on login page
	When User enters valid username
	And User enters valid password
	And User clicks on Login button
	Then Log Off button is displayed
