Feature: Registration

Registration flow: user registers from the website header

@Registration
Scenario: Registration
	Given User is on home page
	When User clicks on header Registration button
	And User fills in form details <gender>, <firstName>, <lastName>, <DateOfBirth>, <MonthOfBirth>, <YearOfBirth>, <email>, <companyName>, <password> and <confirmationPassword>
	And User clicks on Register button
	Then We can click the Continue button
	Examples: 
	| gender | firstName | lastName | DateOfBirth | MonthOfBirth | YearOfBirth | email             | companyName | password   | confirmationPassword |
	| female | Stacey    | Ng       | 13          | February     | 1998        | staceyng11@test.com | RAPP IO     | Testing123 | Testing123           |
