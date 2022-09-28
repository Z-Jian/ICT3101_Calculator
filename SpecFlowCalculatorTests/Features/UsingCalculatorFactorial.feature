Feature: UsingCalculatorFactorial

A short summary of the feature

@Factorial
Scenario: Factorial with whole numbers
	Given I have a calculator
	When I have entered <value1> into the calculator and press factorial
	Then the factorial result should be <value2>
	Examples: 
	| value1 | value2 |
	| 0      | 1      |
	| 1	     | 1      |
	| 3      | 6      |
 
