Feature: CheckCartTotal
	In order to avoid overspending
	When I add multiple products in the cart
	The final total should be correct

@mytag
Scenario: CheckCartTotal
	Given I go to dresses page
	And I add 2 dresses into the cart
	When I navigate to cart
	Then the final total should add up