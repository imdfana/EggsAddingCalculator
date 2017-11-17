Feature: Multiplication
	In order to know the total amount of eggs for a group sales 
	As a Eggs Seller
	I want to be able to make a multiplication of two number


@Multiplication
Scenario: Multiplicate two numbers
	Given I have entered 5 into the calculator
	And  I have also entered 3 into the calculator
	When I select operator 'x'
	Then the result should be 15 on the screen
