Feature: AuthenticationScenarios
	In order to validate Sign-Up page
	As a new user
	I want to be able to crete a new account

#@mytag
#Scenario: Verify a user can create account
#	Given I navigate to "test"
#		And I navigate to "sign in"
#	When I enter an email address
#		And I click create an account
#		And I fill in the required fields
#		And I click register
#	Then I should see a confirmation message

@mytag
Scenario: Verify a user can create account
	Given I am on "Sign-up" page
	#When I create my account and I "save"
	When I create my account
	| Email                   | Title | FirstName | LastName | Password   | DateOfBirth     | Address | City     | State      | Country       | MobilePhone | AliasAddress | ZipCode |
	| email1TestRadu@Test.com | Mr.   | Radu      | Flitar   | loginpass1 | 12/10/1989 | Lunii   | Sanpetru | California | United States | 0007454567  | Fagaras      | 12345   |
	Then I should see confirmation message
		And I login with my credentials
	Then I should see my account
