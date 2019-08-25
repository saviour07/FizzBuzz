using FizzBuzz;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzzWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, System.EventArgs e)
        {
            var logic = new Logic();
            var sb = new StringBuilder();
            var outputWinform = new OutputWinform(OutputTextBox);
            for (int i = 0; i <= InputNumSpinner.Value; ++i)
            {
                var output = logic.Run(i);
                sb.AppendLine($"{i}: {output}");
                outputWinform.Output(sb.ToString());
            }
        }
    }
}
