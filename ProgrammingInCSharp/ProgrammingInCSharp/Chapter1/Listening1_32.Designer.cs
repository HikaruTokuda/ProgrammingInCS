namespace ProgrammingInCSharp.Chapter1
{
    partial class Listening1_32
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
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultTextBlock = new System.Windows.Forms.TextBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(190, 69);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(438, 22);
            this.URLTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultTextBlock
            // 
            this.ResultTextBlock.Location = new System.Drawing.Point(200, 226);
            this.ResultTextBlock.Name = "ResultTextBlock";
            this.ResultTextBlock.Size = new System.Drawing.Size(444, 22);
            this.ResultTextBlock.TabIndex = 2;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(190, 299);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(444, 22);
            this.StatusTextBox.TabIndex = 3;
            // 
            // Listening1_32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.ResultTextBlock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.URLTextBox);
            this.Name = "Listening1_32";
            this.Text = "Listening1_32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultTextBlock;
        private System.Windows.Forms.TextBox StatusTextBox;
    }
}