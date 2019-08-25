using FizzBuzz;

namespace FizzBuzzConsole
{
    public class Program
    {
        public static void Main()
        {
            var outputConsole = new OutputConsole();
            FizzBuzzRunner.Run(1000, outputConsole);
        }
    }
}
