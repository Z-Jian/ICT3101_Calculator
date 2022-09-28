using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorMusaIntensityFailure
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorMusaIntensityFailure(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"I enter the failure intensity decay (.*), initial failure intensity (.*) and the average number of failures (.*)")]
        public void WhenIEnterTheFailureIntensityDecayAndAndTheInitialFailureIntensityAndTheAverageNumberOfFailures(double p0, double p1, double p2)
        {
            _result = _calculator.musaCurrentFailureIntensity(p0, p1, p2);
        }

        [When(@"I enter (.*) cpu hours, the initial failure intensity (.*), failure intensity decay (.*)")]        
        public void WhenIEnterTheFailureIntensityDecayAndAndTheInitialFailureIntensityAndTheAverageNumberOfFailuresAndTheNumberOfCpuHours(double p0, double p1, double p2)
        {
            _result = _calculator.musaNumberOfExpectedFailure(p2, p1, p0);
        }

        [Then(@"the result of failure intensity is (.*)")]
        public void ThenTheResultOfFailureIntensityIs(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the result of expected failure is (.*)")]
        public void ThenTheResultOfExpectedFailureIs(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}