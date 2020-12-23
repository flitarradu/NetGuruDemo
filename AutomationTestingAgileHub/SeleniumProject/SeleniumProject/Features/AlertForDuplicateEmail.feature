Feature: AlertForDuplicateEmail
	When I try to register an account
	And I enter an already used password
	I should receive an alert telling me this

@mytag
Scenario: AlertForDuplicateEmail
	Given I enter the login page
	And I enter an used email address
			| userEmail        |
			| <userEmailValue> |
	When I click the register button
	Then I see an alert

Examples: 
| userEmailValue         |
| testradu@someemail.com | 