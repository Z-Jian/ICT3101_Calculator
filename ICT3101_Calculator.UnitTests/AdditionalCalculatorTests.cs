using Moq;
using NUnit.Framework;
using System;

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
            _mockFileReader.Setup(fr => fr.Read("./../../../MagicNumbers.txt")).Returns(new string[2] {"-42", "42"});
        }

        [TestCase(0, ExpectedResult = 84)]
        [TestCase(1, ExpectedResult = 84)]

        public double GenMagicNum_WhenGivenTxtFile_Result(double num1)
        {
            return GenMagicNum(num1, _mockFileReader.Object);
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            IFileReader getTheMagic = fileReader;
            //----------------------------------------
            string[] magicStrings = getTheMagic.Read("./../../../MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

    }
}
