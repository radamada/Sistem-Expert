namespace SistemExperRadaProcop
{
    partial class Form2
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.possAnswers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(107, 81);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(0, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Visible = false;
            this.labelQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // possAnswers
            // 
            this.possAnswers.FormattingEnabled = true;
            this.possAnswers.Location = new System.Drawing.Point(85, 133);
            this.possAnswers.Name = "possAnswers";
            this.possAnswers.Size = new System.Drawing.Size(120, 94);
            this.possAnswers.TabIndex = 1;
            this.possAnswers.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 534);
            this.Controls.Add(this.possAnswers);
            this.Controls.Add(this.labelQuestion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.CheckedListBox possAnswers;
    }
}