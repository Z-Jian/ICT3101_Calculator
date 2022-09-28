Feature: UsingCalculatorMusafeature

A short summary of the feature

@MUSA
Scenario: calculate failure intensity using MUSA Log model
Given I have a calculator 
When I enter the failure intensity decay 0.02, initial failure intensity 10 and the average number of failures 50
Then the result of failure intensity is 3.68

@MUSA
Scenario: calculate the number of expected failures using MUSA Log model
Given I have a calculator 
When I enter 10 cpu hours, the initial failure intensity 10, failure intensity decay 0.02
Then the result of expected failure is 55