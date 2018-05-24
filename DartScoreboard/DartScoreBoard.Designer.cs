namespace Dartboard
{
    partial class DartBoardMainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl1 = new System.Windows.Forms.ListBox();
            this.pl2 = new System.Windows.Forms.ListBox();
            this.Reset = new System.Windows.Forms.Button();
            this.pl1Undo = new System.Windows.Forms.Button();
            this.pl1Score = new System.Windows.Forms.TextBox();
            this.pl2Score = new System.Windows.Forms.TextBox();
            this.pl2Undo = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pl13DartScore = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pl23DartScore = new System.Windows.Forms.ListBox();
            this.pl2p2 = new System.Windows.Forms.Panel();
            this.pl2p1 = new System.Windows.Forms.Panel();
            this.pl1p1 = new System.Windows.Forms.Panel();
            this.pl1p2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pl1
            // 
            this.pl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pl1.FormattingEnabled = true;
            this.pl1.ItemHeight = 37;
            this.pl1.Items.AddRange(new object[] {
            "301"});
            this.pl1.Location = new System.Drawing.Point(12, 153);
            this.pl1.Name = "pl1";
            this.pl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl1.Size = new System.Drawing.Size(131, 448);
            this.pl1.TabIndex = 0;
            // 
            // pl2
            // 
            this.pl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2.FormattingEnabled = true;
            this.pl2.ItemHeight = 37;
            this.pl2.Items.AddRange(new object[] {
            "301"});
            this.pl2.Location = new System.Drawing.Point(309, 153);
            this.pl2.Name = "pl2";
            this.pl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl2.Size = new System.Drawing.Size(131, 448);
            this.pl2.TabIndex = 1;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(12, 7);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(445, 103);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "RESET";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // pl1Undo
            // 
            this.pl1Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1Undo.Location = new System.Drawing.Point(12, 611);
            this.pl1Undo.Name = "pl1Undo";
            this.pl1Undo.Size = new System.Drawing.Size(131, 42);
            this.pl1Undo.TabIndex = 3;
            this.pl1Undo.Text = "Undo";
            this.pl1Undo.UseVisualStyleBackColor = true;
            this.pl1Undo.Click += new System.EventHandler(this.pl1Undo_Click);
            // 
            // pl1Score
            // 
            this.pl1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl1Score.Location = new System.Drawing.Point(154, 609);
            this.pl1Score.Name = "pl1Score";
            this.pl1Score.Size = new System.Drawing.Size(130, 44);
            this.pl1Score.TabIndex = 4;
            this.pl1Score.Enter += new System.EventHandler(this.pl1Score_Enter);
            this.pl1Score.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pl1Score_Enter);
            // 
            // pl2Score
            // 
            this.pl2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2Score.Location = new System.Drawing.Point(450, 609);
            this.pl2Score.Name = "pl2Score";
            this.pl2Score.Size = new System.Drawing.Size(130, 44);
            this.pl2Score.TabIndex = 6;
            this.pl2Score.Enter += new System.EventHandler(this.pl2Score_Enter);
            this.pl2Score.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pl2_KeyDown);
            // 
            // pl2Undo
            // 
            this.pl2Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl2Undo.Location = new System.Drawing.Point(309, 611);
            this.pl2Undo.Name = "pl2Undo";
            this.pl2Undo.Size = new System.Drawing.Size(131, 42);
            this.pl2Undo.TabIndex = 5;
            this.pl2Undo.Text = "Undo";
            this.pl2Undo.UseVisualStyleBackColor = true;
            this.pl2Undo.Click += new System.EventHandler(this.pl2Undo_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "901",
            "501",
            "301"});
            this.checkedListBox1.Location = new System.Drawing.Point(463, 7);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(117, 103);
            this.checkedListBox1.TabIndex = 9;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // pl13DartScore
            // 
            this.pl13DartScore.Enabled = false;
            this.pl13DartScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl13DartScore.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pl13DartScore.FormattingEnabled = true;
            this.pl13DartScore.ItemHeight = 37;
            this.pl13DartScore.Location = new System.Drawing.Point(153, 153);
            this.pl13DartScore.Name = "pl13DartScore";
            this.pl13DartScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl13DartScore.Size = new System.Drawing.Size(131, 448);
            this.pl13DartScore.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "       Player 1       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "       Player 2       ";
            // 
            // pl23DartScore
            // 
            this.pl23DartScore.Enabled = false;
            this.pl23DartScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl23DartScore.FormattingEnabled = true;
            this.pl23DartScore.ItemHeight = 37;
            this.pl23DartScore.Location = new System.Drawing.Point(449, 153);
            this.pl23DartScore.Name = "pl23DartScore";
            this.pl23DartScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl23DartScore.Size = new System.Drawing.Size(131, 448);
            this.pl23DartScore.TabIndex = 13;
            // 
            // pl2p2
            // 
            this.pl2p2.BackColor = System.Drawing.Color.Transparent;
            this.pl2p2.Location = new System.Drawing.Point(552, 122);
            this.pl2p2.Name = "pl2p2";
            this.pl2p2.Size = new System.Drawing.Size(28, 28);
            this.pl2p2.TabIndex = 14;
            // 
            // pl2p1
            // 
            this.pl2p1.BackColor = System.Drawing.Color.Transparent;
            this.pl2p1.Location = new System.Drawing.Point(309, 122);
            this.pl2p1.Name = "pl2p1";
            this.pl2p1.Size = new System.Drawing.Size(28, 28);
            this.pl2p1.TabIndex = 15;
            // 
            // pl1p1
            // 
            this.pl1p1.BackColor = System.Drawing.Color.ForestGreen;
            this.pl1p1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pl1p1.Location = new System.Drawing.Point(12, 122);
            this.pl1p1.Name = "pl1p1";
            this.pl1p1.Size = new System.Drawing.Size(28, 28);
            this.pl1p1.TabIndex = 16;
            // 
            // pl1p2
            // 
            this.pl1p2.BackColor = System.Drawing.Color.ForestGreen;
            this.pl1p2.Location = new System.Drawing.Point(256, 122);
            this.pl1p2.Name = "pl1p2";
            this.pl1p2.Size = new System.Drawing.Size(28, 28);
            this.pl1p2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 659);
            this.Controls.Add(this.pl1p2);
            this.Controls.Add(this.pl1p1);
            this.Controls.Add(this.pl2p1);
            this.Controls.Add(this.pl2p2);
            this.Controls.Add(this.pl23DartScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl13DartScore);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pl2Score);
            this.Controls.Add(this.pl2Undo);
            this.Controls.Add(this.pl1Score);
            this.Controls.Add(this.pl1Undo);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.pl2);
            this.Controls.Add(this.pl1);
            this.Name = "Form1";
            this.Text = "Dart Scoreboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pl1;
        private System.Windows.Forms.ListBox pl2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button pl1Undo;
        private System.Windows.Forms.TextBox pl1Score;
        private System.Windows.Forms.TextBox pl2Score;
        private System.Windows.Forms.Button pl2Undo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox pl13DartScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pl23DartScore;
        private System.Windows.Forms.Panel pl2p2;
        private System.Windows.Forms.Panel pl2p1;
        private System.Windows.Forms.Panel pl1p1;
        private System.Windows.Forms.Panel pl1p2;
    }
}

