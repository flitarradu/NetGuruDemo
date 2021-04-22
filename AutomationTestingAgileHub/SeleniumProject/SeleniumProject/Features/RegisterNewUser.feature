Feature: RegisterNewUser
	In order access an accout
	I have to register an user first

@mytag
Scenario: RegisterNewUser
	Given I navigate to website and click login
	Then I fill desired email
	| userEmail        |
	| <userEmailValue> |
	When I fill the register form with following data
			| userFirstName        | userLastName        | userPhone        | userAddress        | userPassword        | userAddressFirstName        | userAddressLastName        | userCity        | userPostalCode        |
			| <userFirstNameValue> | <userLastNameValue> | <userPhoneValue> | <userAddressValue> | <userPasswordValue> | <userAddressFirstNameValue> | <userAddressLastNameValue> | <userCityValue> | <userPostalCodeValue> |
	And I click the register button
	Then I am successfully logged in

Examples: 
| userEmailValue          | userFirstNameValue | userLastNameValue | userPhoneValue | userAddressValue  | userPasswordValue | userAddressFirstNameValue | userAddressLastNameValue | userCityValue | userPostalCodeValue |
| testradu5@someemail.com | Radu               | Nicolae           | 202-555-0187   | Sanpetru, Lunii 2 | testpassword123   | Radu                      | Nicolae                  | Brasov        | 23456               |