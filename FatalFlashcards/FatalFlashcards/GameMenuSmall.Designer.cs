
namespace FatalFlashcards
{
    partial class GameMenuSmall
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblBestSpeed = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblBestPoints = new System.Windows.Forms.Label();
            this.cboCardSet = new System.Windows.Forms.ComboBox();
            this.lblFlashcards = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddCards = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClose.Location = new System.Drawing.Point(765, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.LeaveText);
            this.lblClose.MouseHover += new System.EventHandler(this.HoverText);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSpeed.Location = new System.Drawing.Point(12, 163);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(58, 18);
            this.lblSpeed.TabIndex = 22;
            this.lblSpeed.Text = "59:59";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBestSpeed
            // 
            this.lblBestSpeed.AutoSize = true;
            this.lblBestSpeed.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestSpeed.ForeColor = System.Drawing.Color.Gold;
            this.lblBestSpeed.Location = new System.Drawing.Point(12, 133);
            this.lblBestSpeed.Name = "lblBestSpeed";
            this.lblBestSpeed.Size = new System.Drawing.Size(128, 18);
            this.lblBestSpeed.TabIndex = 21;
            this.lblBestSpeed.Text = "Fastest Run:";
            this.lblBestSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPoints.Location = new System.Drawing.Point(12, 102);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(18, 18);
            this.lblPoints.TabIndex = 20;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBestPoints
            // 
            this.lblBestPoints.AutoSize = true;
            this.lblBestPoints.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestPoints.ForeColor = System.Drawing.Color.Gold;
            this.lblBestPoints.Location = new System.Drawing.Point(12, 72);
            this.lblBestPoints.Name = "lblBestPoints";
            this.lblBestPoints.Size = new System.Drawing.Size(98, 18);
            this.lblBestPoints.TabIndex = 19;
            this.lblBestPoints.Text = "Best Run:";
            this.lblBestPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCardSet
            // 
            this.cboCardSet.BackColor = System.Drawing.SystemColors.ControlText;
            this.cboCardSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCardSet.ForeColor = System.Drawing.SystemColors.Window;
            this.cboCardSet.FormattingEnabled = true;
            this.cboCardSet.Location = new System.Drawing.Point(12, 30);
            this.cboCardSet.Name = "cboCardSet";
            this.cboCardSet.Size = new System.Drawing.Size(148, 29);
            this.cboCardSet.TabIndex = 18;
            this.cboCardSet.SelectedIndexChanged += new System.EventHandler(this.cboCardSet_SelectedIndexChanged);
            // 
            // lblFlashcards
            // 
            this.lblFlashcards.AutoSize = true;
            this.lblFlashcards.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFlashcards.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFlashcards.Location = new System.Drawing.Point(12, 9);
            this.lblFlashcards.Name = "lblFlashcards";
            this.lblFlashcards.Size = new System.Drawing.Size(148, 18);
            this.lblFlashcards.TabIndex = 17;
            this.lblFlashcards.Text = "Flashcard Set:";
            this.lblFlashcards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuit.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuit.Location = new System.Drawing.Point(321, 274);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(109, 22);
            this.lblQuit.TabIndex = 27;
            this.lblQuit.Text = "Quit Game";
            this.lblQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            this.lblQuit.MouseLeave += new System.EventHandler(this.LeaveText);
            this.lblQuit.MouseHover += new System.EventHandler(this.HoverText);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(317, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fatal Flashcards";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(321, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "How to Upload Sets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.LeaveText);
            this.label1.MouseHover += new System.EventHandler(this.HoverText);
            // 
            // lblAddCards
            // 
            this.lblAddCards.AutoSize = true;
            this.lblAddCards.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddCards.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddCards.Location = new System.Drawing.Point(321, 214);
            this.lblAddCards.Name = "lblAddCards";
            this.lblAddCards.Size = new System.Drawing.Size(197, 22);
            this.lblAddCards.TabIndex = 24;
            this.lblAddCards.Text = "Add Flashcard Set";
            this.lblAddCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddCards.Click += new System.EventHandler(this.lblAddCards_Click);
            this.lblAddCards.MouseLeave += new System.EventHandler(this.LeaveText);
            this.lblAddCards.MouseHover += new System.EventHandler(this.HoverText);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlay.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlay.Location = new System.Drawing.Point(321, 184);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(65, 22);
            this.lblPlay.TabIndex = 23;
            this.lblPlay.Text = "Begin";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.LeaveText);
            this.lblPlay.MouseHover += new System.EventHandler(this.HoverText);
            // 
            // GameMenuSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddCards);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblBestSpeed);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblBestPoints);
            this.Controls.Add(this.cboCardSet);
            this.Controls.Add(this.lblFlashcards);
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenuSmall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenuSmall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblBestSpeed;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblBestPoints;
        private System.Windows.Forms.ComboBox cboCardSet;
        private System.Windows.Forms.Label lblFlashcards;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddCards;
        private System.Windows.Forms.Label lblPlay;
    }
}