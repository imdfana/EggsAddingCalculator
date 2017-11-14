Feature: Identity Element of the Addition
	In order to be have an exact Calculator
	I as a Eggs Seller
	Want that the Calculator handles properly the Identity Element for the Addition operation (zero)

@Addition
Scenario Outline: Adding with Zero
	Given I have entered 0 into the calculator
	And I have also entered <operand> into the calculator
	When I select Add
	Then the result should be <operand> on the screen

Examples:
	| operand |
	| -1      |
	| 0       |
	| 1       |
