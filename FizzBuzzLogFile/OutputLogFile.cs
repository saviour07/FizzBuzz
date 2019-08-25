using FizzBuzz;
using System.IO;

namespace FizzBuzzLogFile
{
    public class OutputLogFile : IOutputFizzBuzz
    {
        private readonly string _logFilePath;

        public OutputLogFile(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        public void Output(string output)
        {
            using (var fs = new StreamWriter(_logFilePath, true))
            {
                fs.WriteLine(output);
            }
        }
    }
}
