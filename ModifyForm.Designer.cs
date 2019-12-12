namespace swf_MainForm
{
    partial class ModifyForm
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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnQuitNoSave = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.rtxtEditAnswer = new System.Windows.Forms.RichTextBox();
            this.rtxtEditQuestion = new System.Windows.Forms.RichTextBox();
            this.pnlCardDisplay = new System.Windows.Forms.Panel();
            this.lstCardDisplay = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDeckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveReturn = new System.Windows.Forms.Button();
            this.pnlEdit.SuspendLayout();
            this.pnlCardDisplay.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Silver;
            this.pnlEdit.Controls.Add(this.btnSaveReturn);
            this.pnlEdit.Controls.Add(this.lblAnswer);
            this.pnlEdit.Controls.Add(this.lblQuestion);
            this.pnlEdit.Controls.Add(this.btnQuitNoSave);
            this.pnlEdit.Controls.Add(this.btnSaveAdd);
            this.pnlEdit.Controls.Add(this.rtxtEditAnswer);
            this.pnlEdit.Controls.Add(this.rtxtEditQuestion);
            this.pnlEdit.Location = new System.Drawing.Point(12, 36);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(455, 289);
            this.pnlEdit.TabIndex = 0;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(3, 127);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(84, 25);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 14);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuitNoSave
            // 
            this.btnQuitNoSave.BackColor = System.Drawing.Color.DimGray;
            this.btnQuitNoSave.Location = new System.Drawing.Point(307, 244);
            this.btnQuitNoSave.Name = "btnQuitNoSave";
            this.btnQuitNoSave.Size = new System.Drawing.Size(146, 32);
            this.btnQuitNoSave.TabIndex = 4;
            this.btnQuitNoSave.Text = "Quit without Saving";
            this.btnQuitNoSave.UseVisualStyleBackColor = false;
            this.btnQuitNoSave.Click += new System.EventHandler(this.btnQuitNoSave_Click);
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(3, 244);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(146, 32);
            this.btnSaveAdd.TabIndex = 2;
            this.btnSaveAdd.Text = "Add / Update";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // rtxtEditAnswer
            // 
            this.rtxtEditAnswer.BackColor = System.Drawing.Color.White;
            this.rtxtEditAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtEditAnswer.Location = new System.Drawing.Point(3, 155);
            this.rtxtEditAnswer.Name = "rtxtEditAnswer";
            this.rtxtEditAnswer.Size = new System.Drawing.Size(449, 82);
            this.rtxtEditAnswer.TabIndex = 1;
            this.rtxtEditAnswer.Text = "";
            // 
            // rtxtEditQuestion
            // 
            this.rtxtEditQuestion.BackColor = System.Drawing.Color.White;
            this.rtxtEditQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtEditQuestion.Location = new System.Drawing.Point(3, 42);
            this.rtxtEditQuestion.Name = "rtxtEditQuestion";
            this.rtxtEditQuestion.Size = new System.Drawing.Size(449, 82);
            this.rtxtEditQuestion.TabIndex = 0;
            this.rtxtEditQuestion.Text = "";
            // 
            // pnlCardDisplay
            // 
            this.pnlCardDisplay.Controls.Add(this.lstCardDisplay);
            this.pnlCardDisplay.Location = new System.Drawing.Point(473, 36);
            this.pnlCardDisplay.Name = "pnlCardDisplay";
            this.pnlCardDisplay.Size = new System.Drawing.Size(208, 289);
            this.pnlCardDisplay.TabIndex = 5;
            // 
            // lstCardDisplay
            // 
            this.lstCardDisplay.FormattingEnabled = true;
            this.lstCardDisplay.Location = new System.Drawing.Point(3, 9);
            this.lstCardDisplay.Name = "lstCardDisplay";
            this.lstCardDisplay.Size = new System.Drawing.Size(202, 277);
            this.lstCardDisplay.TabIndex = 0;
            this.lstCardDisplay.SelectedIndexChanged += new System.EventHandler(this.lstCardDisplay_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDeckToolStripMenuItem,
            this.openDeckToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openDeckToolStripMenuItem
            // 
            this.openDeckToolStripMenuItem.Name = "openDeckToolStripMenuItem";
            this.openDeckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDeckToolStripMenuItem.Text = "&New Deck";
            this.openDeckToolStripMenuItem.Click += new System.EventHandler(this.openDeckToolStripMenuItem_Click);
            // 
            // openDeckToolStripMenuItem1
            // 
            this.openDeckToolStripMenuItem1.Name = "openDeckToolStripMenuItem1";
            this.openDeckToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.openDeckToolStripMenuItem1.Text = "&Open Deck";
            this.openDeckToolStripMenuItem1.Click += new System.EventHandler(this.openDeckToolStripMenuItem1_Click);
            // 
            // btnSaveReturn
            // 
            this.btnSaveReturn.Location = new System.Drawing.Point(148, 244);
            this.btnSaveReturn.Name = "btnSaveReturn";
            this.btnSaveReturn.Size = new System.Drawing.Size(161, 32);
            this.btnSaveReturn.TabIndex = 7;
            this.btnSaveReturn.Text = "Save Deck and Go to Menu";
            this.btnSaveReturn.UseVisualStyleBackColor = true;
            this.btnSaveReturn.Click += new System.EventHandler(this.btnSaveReturn_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 331);
            this.Controls.Add(this.pnlCardDisplay);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Study With Flashcards";
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlCardDisplay.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.RichTextBox rtxtEditAnswer;
        private System.Windows.Forms.RichTextBox rtxtEditQuestion;
        private System.Windows.Forms.Button btnQuitNoSave;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlCardDisplay;
        private System.Windows.Forms.ListBox lstCardDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDeckToolStripMenuItem1;
        private System.Windows.Forms.Button btnSaveReturn;
    }
}