Feature: CheckWishListSaving
	Verify the wishList functionality
	Will verify if one item is saved in wishlist

@mytag
Scenario: CheckWishListSaving
	Given I am logged in with following user
			| userEmail        | userPassword        |
			| <userEmailValue> | <userPasswordValue> |
	When I add a dress to the wish list
	And navigate to account's wish list
	Then I see the dress added to the list

Examples: 
| userEmailValue         | userPasswordValue |
| testradu@someemail.com | testpassword123   |