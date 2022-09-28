Feature: UsingCalculatorDefectDensity
Calculating defect density of a system as well as calculation for new total number of shipped source instructions

Name: Calculate quality metric
Story 1: Calculate defect density
Story 2: Calculate total number of Shipped Source Instructions
Story 3: Calculate failure intensity using Musa Logarithmic
Story 4: Calculate Number of expected failures using Musa Logarithmic


@DefectDensity
Scenario: calculate defect density
Given I have a calculator
When I input the number of defects 100 and the number of lines in the code 50
Then the defect density results should be 2.0

@DefectDensity
Scenario: calculate new total of shipped instructions 
Given I have a calculator 
When I input the number of KSSI 50 and the number of KCSI 20 and number of delete and change code 4
Then the results of total new shipped source instructions is 66