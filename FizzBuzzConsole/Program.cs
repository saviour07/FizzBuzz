using FizzBuzz;
using System;

namespace FizzBuzzConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logic = new Logic();
            for (int i = 0; i <= 1000; ++i)
            {
                var output = logic.Run(i);
                Console.WriteLine($"{i}: {output}");
            }
        }
    }
}
