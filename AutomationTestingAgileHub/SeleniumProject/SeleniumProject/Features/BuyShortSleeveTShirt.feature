Feature: BuyShortSleeveTShirt
	In order buy a T-shirt
	I must login first
	Add the product to cart and complete checkout

@mytag
Scenario: BuyShortSleeveTShirt
	Given I am logged in with existing user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	When I add the T-shirt to cart
	And I access the cart to proceed to checkout
	And I finish the checkout steps
	Then My order is completed

Examples: 
| userEmailValue         | userPasswordValue |
| testradu@someemail.com | testpassword123   |