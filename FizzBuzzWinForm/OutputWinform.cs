using FizzBuzz;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzzWinForm
{
    public class OutputWinform : IOutputFizzBuzz
    {
        private readonly RichTextBox _txtBox;
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public OutputWinform(RichTextBox txtBox)
        {
            _txtBox = txtBox;
        }

        public void Output(string output)
        {
            _stringBuilder.AppendLine(output);
            _txtBox.Text = _stringBuilder.ToString();
        }
    }
}
