namespace ProgrammingInCSharp.Chapter1
{
    partial class Listening1_29
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
            this.numberOfValuesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberOfValuesTextBox
            // 
            this.numberOfValuesTextBox.Location = new System.Drawing.Point(227, 84);
            this.numberOfValuesTextBox.Name = "numberOfValuesTextBox";
            this.numberOfValuesTextBox.Size = new System.Drawing.Size(337, 22);
            this.numberOfValuesTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Location = new System.Drawing.Point(371, 282);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(43, 15);
            this.ResultText.TabIndex = 2;
            this.ResultText.Text = "label1";
            // 
            // Listening1_29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberOfValuesTextBox);
            this.Name = "Listening1_29";
            this.Text = "Listening1_29";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOfValuesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultText;
    }
}