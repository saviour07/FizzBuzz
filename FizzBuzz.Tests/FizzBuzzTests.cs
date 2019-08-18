using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(9, "Fizz")]
        [DataRow(12, "Fizz")]
        [DataRow(18, "Fizz")]
        [DataRow(21, "Fizz")]
        [DataRow(24, "Fizz")]
        [DataRow(27, "Fizz")]
        [DataRow(33, "Fizz")]
        public void GivenInputIsDivisibleByThree_WhenNotAlsoDivisibleByFive_ThenPrintFizz(int input, string expectedOutput)
        {
            var logic = new Logic();
            var output = logic.Run(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(20, "Buzz")]
        [DataRow(25, "Buzz")]
        [DataRow(35, "Buzz")]
        [DataRow(40, "Buzz")]
        [DataRow(50, "Buzz")]
        [DataRow(55, "Buzz")]
        [DataRow(65, "Buzz")]
        public void GivenInputIsDivisibleByFive_WhenNotAlsoDivisibleByThree_ThenPrintBuzz(int input, string expectedOutput)
        {
            var logic = new Logic();
            var output = logic.Run(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        [DataRow(60, "FizzBuzz")]
        [DataRow(90, "FizzBuzz")]
        public void GivenInputIsDivisibleByThree_WhenAlsoDivisibleByFive_ThenPrintFizzBuzz(int input, string expectedOutput)
        {
            var logic = new Logic();
            var output = logic.Run(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
