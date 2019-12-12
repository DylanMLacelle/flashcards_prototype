namespace swf_MainForm
{
    partial class HelpForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pboxHelpDisplay = new System.Windows.Forms.PictureBox();
            this.lblPageCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHelpDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(322, 469);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 41);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(403, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 41);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pboxHelpDisplay
            // 
            this.pboxHelpDisplay.ErrorImage = null;
            this.pboxHelpDisplay.Image = global::swf_MainForm.Properties.Resources.GeneralHelp;
            this.pboxHelpDisplay.Location = new System.Drawing.Point(12, 12);
            this.pboxHelpDisplay.Name = "pboxHelpDisplay";
            this.pboxHelpDisplay.Size = new System.Drawing.Size(776, 451);
            this.pboxHelpDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxHelpDisplay.TabIndex = 0;
            this.pboxHelpDisplay.TabStop = false;
            // 
            // lblPageCounter
            // 
            this.lblPageCounter.AutoSize = true;
            this.lblPageCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageCounter.Location = new System.Drawing.Point(718, 482);
            this.lblPageCounter.Name = "lblPageCounter";
            this.lblPageCounter.Size = new System.Drawing.Size(54, 25);
            this.lblPageCounter.TabIndex = 3;
            this.lblPageCounter.Text = "0 / 0";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.lblPageCounter);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pboxHelpDisplay);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxHelpDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxHelpDisplay;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPageCounter;
    }
}