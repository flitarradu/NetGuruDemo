Feature: TermsOfServicePopupShown
	In order to order a product
	You must agree to Terms of Service
	And a popup must be shown otherwise

@mytag
Scenario: TermsOfServicePopupShown
	Given I am logged in with following user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	And I add a product into cart
	When I complete the checkout process
	Then I am shown a popup if terms of service is not checked

Examples: 
| userEmailValue         | userPasswordValue |
| testradu@someemail.com | testpassword123   |