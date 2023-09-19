Feature: Calculator
	I created a simple Calculate application
	Which I'm testing Add, Subtract and Multiply Method

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
	Given I gave first number and second number
	| num1 | num2 |
	| 40   | 50   |
