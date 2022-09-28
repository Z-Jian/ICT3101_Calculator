using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorDefectDensityStepDefinition
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorDefectDensityStepDefinition(Calculator _calculator)
        {
            this._calculator = _calculator;
        }
        [When(@"I input the number of defects (.*) and the number of lines in the code (.*)")]
        public void WhenIInputTheNumberOfDefectsAndTheNumberOfLinesInTheCode(int p0, int p1)
        {
            _result = _calculator.defectdensity(p0, p1);
        }

        [When(@"I input the number of KSSI (.*) and the number of KCSI (.*) and number of delete and change code (.*)")]
        public void WhenIInputTheNumberOfKSSIAndTheNumberOfKCSIAndNumberOfDeleteAndChangeCode(int p0, int p1, int p2)
        {
            _result = _calculator.SSIForNewSoftware(p0, p1, p2);
        }

        [Then(@"the defect density results should be (.*)")]
        public void ThenTheDefectDensityResultsShouldBe(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the results of total new shipped source instructions is (.*)")]
        public void ThenTheResultsOfTotalNewShippedSourceInstructionsIs(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}