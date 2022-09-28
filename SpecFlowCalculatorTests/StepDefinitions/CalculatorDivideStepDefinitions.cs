using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorDivideStepDefinitions
    {
        private double _result;
        private readonly Calculator _calculator;

        public CalculatorDivideStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(string p0)
        {
            // Check if the result is the string 
            var result = p0 == "positive_infinity" ? double.PositiveInfinity : double.Parse(p0);
            Assert.That(_result, Is.EqualTo(result));
        }

    }
}

