﻿Feature: Divide
	In order to know the exact quantity of eggs 
	when make a group sales the result must 
	As a Egg seller 
	I want to be abble to devide two numbers 

@Divide
Scenario: Divide two numbers 
	Given I have entered  20 into the calculator 
	And  I have also entered 2 into the calculator 
	When I select operator '/'
	Then the result should be 10 on the screen

		