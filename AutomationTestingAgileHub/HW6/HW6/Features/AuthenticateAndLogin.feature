Feature: AuthenticateAndLogin
	In order to validate Login
	As an admin user
	I want to authenticate int casquad.org

@mytag
Scenario Outline: AuthenticateAndLogin
	Given I navigate to my authentication page
	When I login with following credentials
	| userEmail             |   userPassword		|
	| <userEmailValue>		|   <userPasswordValue> |
	Then I am logged in

Examples: 
| userEmailValue        | userPasswordValue |
| admin.test3@gmail.com | password123       |
| admin.test4@gmail.com | password123       |