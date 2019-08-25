using FizzBuzz;
using System.Windows.Forms;

namespace FizzBuzzWinForm
{
    public class OutputWinform : IOutputFizzBuzz
    {
        private readonly RichTextBox _txtBox;

        public OutputWinform(RichTextBox txtBox)
        {
            _txtBox = txtBox;
        }

        public void Output(string output) => _txtBox.Text = output;
    }
}
