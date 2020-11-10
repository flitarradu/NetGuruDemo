Feature: LoginAndLogout
	In order log out from my site
	I must login first 

@mytag
Scenario Outline: LoginAndLogout
	Given I am logged in on my site with following credentials
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	When I click disconnect button
	Then I am successfully logged out

	Examples: 
| userEmailValue       | userPasswordValue |
| raduflyiat@yahoo.com | parola12345       |