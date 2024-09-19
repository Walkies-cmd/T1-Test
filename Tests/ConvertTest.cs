using NUnit.Framework;
using TechnologyOneTest.Models;

namespace TechnologyOneTest.Tests
{
    [TestFixture]
    public class ConvertTests
    {
        private ConvertModel _convertModel;

        [SetUp]
        public void Setup()
        {
            _convertModel = new ConvertModel();
        }

        [Test]
        public void TC01_ConvertWholeNumberWithoutDecimal()
        {
            decimal input = 123;
            string expectedOutput = "ONE HUNDRED TWENTY-THREE DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC02_ConvertNumberWithDecimal()
        {
            decimal input = 123.45m;
            string expectedOutput = "ONE HUNDRED TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC03_ConvertFourDigit()
        {
            decimal input = 1234;
            string expectedOutput = "ONE THOUSAND TWO HUNDRED THIRTY-FOUR DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC04_ConvertFiveDigit()
        {
            decimal input = 12345;
            string expectedOutput = "TWELVE THOUSAND THREE HUNDRED FORTY-FIVE DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC05_ConvertSixDigit()
        {
            decimal input = 123456;
            string expectedOutput = "ONE HUNDRED TWENTY-THREE THOUSAND FOUR HUNDRED FIFTY-SIX DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC06_ConvertSevenDigit()
        {
            decimal input = 1234567;
            string expectedOutput = "ONE MILLION TWO HUNDRED THIRTY-FOUR THOUSAND FIVE HUNDRED SIXTY-SEVEN DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC07_ConvertNegativeNumber()
        {
            decimal input = -123;
            string expectedOutput = "MINUS ONE HUNDRED TWENTY-THREE DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC08_ConvertNegativeNumberWithDecimal()
        {
            decimal input = -123.45m;
            string expectedOutput = "MINUS ONE HUNDRED TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC09_ConvertZero()
        {
            decimal input = 0;
            string expectedOutput = "ZERO DOLLARS";

            TestConvert(input, expectedOutput);
        }

        [Test]
        public void TC10_TestMaximumValueSupported()
        {
            decimal input = 2147483647.99m;
            string expectedOutput = "TWO BILLION ONE HUNDRED FORTY-SEVEN MILLION FOUR HUNDRED EIGHTY-THREE THOUSAND SIX HUNDRED FORTY-SEVEN DOLLARS AND NINETY-NINE CENTS";

            TestConvert(input, expectedOutput);
        }

        private void TestConvert(decimal input, string expectedOutput)
        {
            _convertModel.InputNumber = input;
            var result = _convertModel.ConvertNumberToWords();

            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
