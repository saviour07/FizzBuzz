using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzRunnerTests
    {
        [TestMethod]
        public void GivenEndIsSetToZero_WhenRunningFizzBuzzRunner_ThenSingleItemIsOutput()
        {
            var end = 0;
            var expectedResult = $"0: {Environment.NewLine}";
            var fakeOutput = new FakeOutput();
            FizzBuzzRunner.Run(end, fakeOutput);
            Assert.AreEqual(expectedResult, fakeOutput.OutputResult);
        }

        [TestMethod]
        public void GivenEndIsSetToOneThousand_WhenRunningFizzBuzzRunner_ThenOneThousandAndOneItemsAreOutput()
        {
            var end = 1000;
            var expectedNumberOfItems = 1001;
            var fakeOutput = new FakeOutput();

            FizzBuzzRunner.Run(end, fakeOutput);

            var actualNumberOfItems = fakeOutput.OutputResult.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(expectedNumberOfItems, actualNumberOfItems.Length);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(3, "3: Fizz")]
        [DataRow(6, "6: Fizz")]
        [DataRow(9, "9: Fizz")]
        [DataRow(12, "12: Fizz")]
        [DataRow(18, "18: Fizz")]
        [DataRow(21, "21: Fizz")]
        [DataRow(24, "24: Fizz")]
        [DataRow(27, "27: Fizz")]
        [DataRow(33, "33: Fizz")]

        [DataRow(5, "5: Buzz")]
        [DataRow(10, "10: Buzz")]
        [DataRow(20, "20: Buzz")]
        [DataRow(25, "25: Buzz")]
        [DataRow(35, "35: Buzz")]
        [DataRow(40, "40: Buzz")]
        [DataRow(50, "50: Buzz")]
        [DataRow(55, "55: Buzz")]
        [DataRow(65, "65: Buzz")]

        [DataRow(15, "15: FizzBuzz")]
        [DataRow(30, "30: FizzBuzz")]
        [DataRow(45, "45: FizzBuzz")]
        [DataRow(60, "60: FizzBuzz")]
        [DataRow(90, "90: FizzBuzz")]
        public void GivenInput_WhenRunningFizzBuzzRunner_ThenOutputTheNumberAndCorrectText(int number, string expectedOutput)
        {
            var fakeOutput = new FakeOutput();

            FizzBuzzRunner.Run(number, fakeOutput);

            var actualItems = fakeOutput.OutputResult.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var actualOutput = actualItems.SingleOrDefault(s => s.StartsWith($"{number}: "));
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
