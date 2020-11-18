Feature: AddToCartUser
	In order to add a product to cart
	I must authenticate as an user
	And then add a product to cart

@mytag
Scenario Outline: AddToCartUser
	Given I login with user
		| userEmail        | userPassword        |
		| <userEmailValue> | <userPasswordValue> |
	When I add a product in the cart
	Then I can see the product in the cart

	Examples: 
| userEmailValue        | userPasswordValue |
| flitar.radu@gmail.com | parola123         |
| admin.test3@gmail.com | password123       |