using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorAvailabilityStepDefinitions
    {
        private double _result;
        private readonly Calculator _calculator;

        public CalculatorAvailabilityStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _result = _calculator.mtbf(p0, p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(string p0)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(p0)));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _result = _calculator.availability(p0, p1);
        }

        [Then(@"the Availability result should be (.*) %")]
        public void ThenTheAvailabilityResultShouldBe(string p0)
        {
            var result = p0 == "positive_infinity" ? double.PositiveInfinity : double.Parse(p0);
            Assert.That(_result, Is.EqualTo(result));
        }
    }

}