using FizzBuzz;

namespace FizzBuzzConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logic = new Logic();
            var outputConsole = new OutputConsole();
            for (int i = 0; i <= 1000; ++i)
            {
                var output = logic.Run(i);
                outputConsole.Output($"{i}: {output}");
            }
        }
    }
}
