﻿namespace WindowsFormsApp2
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.conversion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(207, 25);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(100, 20);
            this.userInput.TabIndex = 0;
            this.userInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // conversion
            // 
            this.conversion.Location = new System.Drawing.Point(207, 90);
            this.conversion.Name = "conversion";
            this.conversion.Size = new System.Drawing.Size(100, 20);
            this.conversion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of seconds elapsed: ";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(15, 90);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 29);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 143);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conversion);
            this.Controls.Add(this.userInput);
            this.MaximumSize = new System.Drawing.Size(352, 182);
            this.MinimumSize = new System.Drawing.Size(352, 182);
            this.Name = "Form1";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox conversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
    }
}

