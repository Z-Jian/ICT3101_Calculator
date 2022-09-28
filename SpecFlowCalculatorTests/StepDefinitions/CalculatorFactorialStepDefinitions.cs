using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorFactorialStepDefinitions
    {
        private double _result;
        private readonly Calculator _calculator;

        public CalculatorFactorialStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(string p0)
        {
            Assert.That(_result, Is.EqualTo(int.Parse(p0)));
        }

    }
}
