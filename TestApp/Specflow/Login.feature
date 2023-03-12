Feature: Login

Login flow: user logins from the website header

@Login
Scenario: Login
	Given User is on home page
	When User clicks on header login button
	And User enters email and password <email> and <password>
	And User clicks on Login button
	Then Log Off button is displayed
	Examples: 
	| email           | password   |
	| stacey@test.com | Testing123 |
	| test@test.com   | Testing123 |
