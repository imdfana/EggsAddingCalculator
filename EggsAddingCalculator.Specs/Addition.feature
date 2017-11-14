Feature: Addition
	To avoid calculation mistakes
	As a Eggs Seller
	I want to be able to sum two numbers

@Addition
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I select Add
	Then the result should be 120 on the screen
