Feature: UsingCalculatorBasicReliability

In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@BasicReliability
Scenario: Calculate Initial Failure Intensity
	Given I have a calculator
	When I have entered <initial>, <avg> and <total> into the calculator and press FI
	Then the FI result should be <result>
	Examples: 
	| initial | avg | total | result |
	| 10      | 50  | 100   | 5      |


@BasicReliability
Scenario: Calculate Average Number of Expected Failures
	Given I have a calculator
	When I have entered <time>, <initial>, <avg> and <total> into the calculator and press AF
	Then the AF result should be <result>
	Examples: 
	| initial | avg | total | time | result |
	| 10      | 50  | 100   | 10   | 63     |
