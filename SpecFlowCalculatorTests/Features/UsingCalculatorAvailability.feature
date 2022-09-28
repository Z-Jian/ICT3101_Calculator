Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered 200 and 10 into the calculator and press MTBF
	Then the MTBF result should be 210

@Availability
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered 200 and 210 into the calculator and press Availability
	Then the Availability result should be 95.2 %

@Availability
Scenario: Zero MTTF and Zero MTTR
	Given I have a calculator
	When I have entered 0 and 0 into the calculator and press MTBF
	Then the MTBF result should be 0

@Availability
Scenario: Zero MTTF and Zero MTBF 
	Given I have a calculator
	When I have entered 0 and 0 into the calculator and press Availability
	Then the Availability result should be 100 %