using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[2] {"42", "42"});
        }

        [TestCase(1, ExpectedResult = 4)]

        public double GenMagicNum_WhenGivenTxtFile_Result(double num1)
        {
            return _calculator.GenMagicNum(num1, _mockFileReader.Object);
        }

    }
}
