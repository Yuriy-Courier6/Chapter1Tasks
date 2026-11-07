using System.Windows.Forms;
using Chapter1.HelloMessageFormatter;

namespace Chapter1.WinForms
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            var label = new Label();
            label.Text = "Enter your name!";
            label.Width = 200;
            label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - label.Width / 2, 10);
            this.Controls.Add(label);

            var input = new TextBox();
            input.Width = 200;
            input.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - input.Width / 2, 40);
            this.Controls.Add(input);

            var toolTip = new Label();
            toolTip.Text = "Type your name and press Enter";
            toolTip.AutoSize = true;
            toolTip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolTip.Width = 200;
            toolTip.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - toolTip.Width / 2, 70);
            this.Controls.Add(toolTip);

            input.TextChanged += (sender, e) =>
            {
                var textInput = input.Text;
                if (string.IsNullOrEmpty(textInput))
                {
                    toolTip.Text = "Type your name and press Enter";
                }
                else
                {
                    toolTip.Text = $"Current input: {textInput}";
                }
            };

            input.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(input.Text))
                    {
                        toolTip.Text = "Input is empty! Enter your name again!";
                        return;
                    }

                    MessageBox.Show(
                        HelloMessageFormatter.
                        Formatter.
                        FormatHelloMessage(input.Text));
                }
            };
        }

        #endregion
    }
}
