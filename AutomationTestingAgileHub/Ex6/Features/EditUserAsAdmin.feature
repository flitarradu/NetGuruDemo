Feature: EditUserAsAdmin
	In order to edit an user
	I must login as Admin first

@mytag
Scenario Outline: EditUserAsAdmin
	Given I am logged in as an admin with credentials "admin.test3@gmail.com" and "password123"
	When I click the Admin button
	And I navigate to Users page
	And I click  Edit and enter the following fields
		| userName        | userEmail        | userPhone        |
		| <userNameValue> | <userEmailValue> | <userPhoneValue> |
	Then The user is successfully edited

Examples:
| userNameValue | userEmailValue       | userPhoneValue |
| Radu          | raduflyiat@yahoo.com | 0745658426     |