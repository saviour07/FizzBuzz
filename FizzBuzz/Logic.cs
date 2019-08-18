using System.Text;

namespace FizzBuzz
{
    public class Logic
    {
        public string Run(int input)
        {
            if (input <= 0)
            {
                return string.Empty;
            }

            var result = new StringBuilder();
            if (ByThree(input))
            {
                result.Append("Fizz");
            }
            if (ByFive(input))
            {
                result.Append("Buzz");
            }
            return result.ToString();
        }

        private bool ByThree(int input) => ByValue(input, 3);

        private bool ByFive(int input) => ByValue(input, 5);

        private bool ByValue(int input, int value) => input % value == 0;
    }
}
