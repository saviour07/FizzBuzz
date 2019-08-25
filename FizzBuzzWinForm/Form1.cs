using FizzBuzz;
using System;
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
            var outputWinform = new OutputWinform(OutputTextBox);
            var end = Convert.ToInt32(InputNumSpinner.Value);
            FizzBuzzRunner.Run(end, outputWinform);
        }
    }
}
