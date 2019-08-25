namespace FizzBuzzWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputNumSpinner = new System.Windows.Forms.NumericUpDown();
            this.InputSizeLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumSpinner)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputNumSpinner
            // 
            this.InputNumSpinner.Location = new System.Drawing.Point(110, 13);
            this.InputNumSpinner.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.InputNumSpinner.Name = "InputNumSpinner";
            this.InputNumSpinner.Size = new System.Drawing.Size(111, 26);
            this.InputNumSpinner.TabIndex = 0;
            this.InputNumSpinner.ThousandsSeparator = true;
            // 
            // InputSizeLabel
            // 
            this.InputSizeLabel.AutoSize = true;
            this.InputSizeLabel.Location = new System.Drawing.Point(3, 15);
            this.InputSizeLabel.Name = "InputSizeLabel";
            this.InputSizeLabel.Size = new System.Drawing.Size(81, 20);
            this.InputSizeLabel.TabIndex = 1;
            this.InputSizeLabel.Text = "Input Size";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(248, 10);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 31);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.Black;
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.ForeColor = System.Drawing.Color.White;
            this.OutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(361, 425);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 100);
            this.panel1.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTextBox.Enabled = false;
            this.DescriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(361, 100);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.Text = "Enter a value between zero and 1,000 then click the Run button to see the results" +
    " in the output window";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InputSizeLabel);
            this.panel2.Controls.Add(this.InputNumSpinner);
            this.panel2.Controls.Add(this.RunButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 53);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.OutputTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 425);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 578);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(383, 634);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FizzBuzz";
            ((System.ComponentModel.ISupportInitialize)(this.InputNumSpinner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown InputNumSpinner;
        private System.Windows.Forms.Label InputSizeLabel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

