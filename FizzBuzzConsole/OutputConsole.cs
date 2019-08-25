using FizzBuzz;
using System;

namespace FizzBuzzConsole
{
    public class OutputConsole : IOutputFizzBuzz
    {
        public void Output(string output) => Console.WriteLine(output);
    }
}
