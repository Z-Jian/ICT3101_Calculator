using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorBasicReliabilityStepDefinitions
    {
        private double _result;
        private readonly Calculator _calculator;

        public CalculatorBasicReliabilityStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press FI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1, int p2)
        {
            _result = _calculator.currentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the FI result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(string p0)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(p0)));
        }

        [When(@"I have entered (.*), (.*), (.*) and (.*) into the calculator and press AF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1, int p2, int p3)
        {
            _result = _calculator.averageFailure(p0, p1, p2, p3);
        }

        [Then(@"the AF result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(string p0)
        {
            var result = p0 == "positive_infinity" ? double.PositiveInfinity : double.Parse(p0);
            Assert.That(_result, Is.EqualTo(result));
        }


    }

}