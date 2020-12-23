Feature: LoginWithExistingUser
	In order make a purchase
	I need to login first

@mytag
Scenario: LoginWithExistingUser
	Given I click the login button
	When I login with the following credentials
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	Then I am succsfully logged in

Examples: 
| userEmailValue         | userPasswordValue |
| testradu@someemail.com | testpassword123   |