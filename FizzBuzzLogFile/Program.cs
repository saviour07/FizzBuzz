using FizzBuzz;
using System;

namespace FizzBuzzLogFile
{
    public class Program
    {
        public static void Main()
        {
            var outputLogFile = new OutputLogFile(Environment.ExpandEnvironmentVariables("%AppData%\\FizzBuzz.log"));
            FizzBuzzRunner.Run(1000, outputLogFile);
        }
    }
}
