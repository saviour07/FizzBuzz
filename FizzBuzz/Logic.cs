namespace FizzBuzz
{
    public class Logic
    {
        public string Run(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            return string.Empty;
        }
    }
}
