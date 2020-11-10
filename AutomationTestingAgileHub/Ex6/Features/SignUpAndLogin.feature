Feature: SignUpAndLogin
	In order login
	I want to create an user first

@signUp
Scenario Outline: SignUpAndLogin
	Given I navigate to my website and click SignUp
	When I fill the signup form with following data
		| userName        | userEmail        | userPhone        | userAddress        | userPassword        | userPasswordRepeat        |
		| <userNameValue> | <userEmailValue> | <userPhoneValue> | <userAddressValue> | <userPasswordValue> | <userPasswordRepeatValue> |
	And I click the sign up button
	And I login with newly created user
	| userEmail        | userPassword        |
	| <userEmailValue> | <userPasswordValue> |
	Then I am successfully logged in with new aacount


Examples: 
| userNameValue | userEmailValue  | userPhoneValue | userAddressValue | userPasswordValue | userPasswordRepeatValue |
| Radu          | raduflyiat@yahoo.com | 0745658426     | Sanpetru, BV     | parola12345       | parola12345             |