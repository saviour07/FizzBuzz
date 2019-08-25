using System.Text;

namespace FizzBuzz.Tests
{
    public class FakeOutput : IOutputFizzBuzz
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public string OutputResult => _stringBuilder.ToString();

        public void Output(string output) => _stringBuilder.AppendLine(output);
    }
}
