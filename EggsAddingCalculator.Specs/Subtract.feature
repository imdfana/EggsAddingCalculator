Feature: Subtract
	In order to subtract the return eggs of the sales
	As a Egg Sellers
	I want to be abble to subtract a number from another 

@Subtract
Scenario: Subtract two numbers
	Given I have entered 10 into the calculator
	And I have entered 5 into the calculator
	When I select Subtract
	Then the result should be 5 on the screen
