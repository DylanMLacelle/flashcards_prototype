namespace swf_MainForm
{
    partial class StudyForm
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
            this.pnlCardDisplay = new System.Windows.Forms.Panel();
            this.pnlSelfEvaluation = new System.Windows.Forms.Panel();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.pnlSelfEvaluation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardDisplay
            // 
            this.pnlCardDisplay.Location = new System.Drawing.Point(17, 21);
            this.pnlCardDisplay.Name = "pnlCardDisplay";
            this.pnlCardDisplay.Size = new System.Drawing.Size(447, 365);
            this.pnlCardDisplay.TabIndex = 0;
            // 
            // pnlSelfEvaluation
            // 
            this.pnlSelfEvaluation.Controls.Add(this.btnShowAnswer);
            this.pnlSelfEvaluation.Controls.Add(this.btnIncorrect);
            this.pnlSelfEvaluation.Controls.Add(this.btnCorrect);
            this.pnlSelfEvaluation.Location = new System.Drawing.Point(17, 392);
            this.pnlSelfEvaluation.Name = "pnlSelfEvaluation";
            this.pnlSelfEvaluation.Size = new System.Drawing.Size(447, 46);
            this.pnlSelfEvaluation.TabIndex = 1;
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(179, 4);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(90, 39);
            this.btnShowAnswer.TabIndex = 2;
            this.btnShowAnswer.Text = "ShowAnswer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.BackColor = System.Drawing.Color.Red;
            this.btnIncorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncorrect.Location = new System.Drawing.Point(275, 4);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(169, 39);
            this.btnIncorrect.TabIndex = 1;
            this.btnIncorrect.Text = "I WAS INCORRECT";
            this.btnIncorrect.UseVisualStyleBackColor = false;
            this.btnIncorrect.Visible = false;
            this.btnIncorrect.Click += new System.EventHandler(this.btnIncorrect_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.Lime;
            this.btnCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCorrect.Location = new System.Drawing.Point(4, 4);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(169, 39);
            this.btnCorrect.TabIndex = 0;
            this.btnCorrect.Text = "I WAS CORRECT";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Visible = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.pnlSelfEvaluation);
            this.Controls.Add(this.pnlCardDisplay);
            this.Name = "StudyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyForm";
            this.Load += new System.EventHandler(this.StudyForm_Load);
            this.pnlSelfEvaluation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardDisplay;
        private System.Windows.Forms.Panel pnlSelfEvaluation;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
        private System.Windows.Forms.Button btnShowAnswer;
    }
}