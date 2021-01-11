Feature: SearchBar
	In order find a product, you can search it in the search bar

@mytag
Scenario: SearchBar
	Given I write 'dress' in the search bar
	And I press the search button
	Then I am shown only 'dress' articles
