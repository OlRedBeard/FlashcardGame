
namespace FatalFlashcards
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.lblClose = new System.Windows.Forms.Label();
            this.picLife = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlAnswerBack = new System.Windows.Forms.Panel();
            this.pnlAnswerFront = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.prgTime = new System.Windows.Forms.ProgressBar();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).BeginInit();
            this.pnlAnswerBack.SuspendLayout();
            this.pnlAnswerFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClose.Location = new System.Drawing.Point(1540, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 33);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLife
            // 
            this.picLife.Image = ((System.Drawing.Image)(resources.GetObject("picLife.Image")));
            this.picLife.Location = new System.Drawing.Point(12, 12);
            this.picLife.Name = "picLife";
            this.picLife.Size = new System.Drawing.Size(100, 99);
            this.picLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife.TabIndex = 7;
            this.picLife.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLives.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLives.Location = new System.Drawing.Point(118, 28);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(70, 73);
            this.lblLives.TabIndex = 9;
            this.lblLives.Text = "0";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuestion.Location = new System.Drawing.Point(300, 105);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1000, 280);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = resources.GetString("lblQuestion.Text");
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerBack
            // 
            this.pnlAnswerBack.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAnswerBack.Controls.Add(this.pnlAnswerFront);
            this.pnlAnswerBack.Location = new System.Drawing.Point(30, 500);
            this.pnlAnswerBack.Name = "pnlAnswerBack";
            this.pnlAnswerBack.Size = new System.Drawing.Size(1540, 350);
            this.pnlAnswerBack.TabIndex = 14;
            // 
            // pnlAnswerFront
            // 
            this.pnlAnswerFront.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnlAnswerFront.Controls.Add(this.lblOptionD);
            this.pnlAnswerFront.Controls.Add(this.lblOptionC);
            this.pnlAnswerFront.Controls.Add(this.lblOptionB);
            this.pnlAnswerFront.Controls.Add(this.lblOptionA);
            this.pnlAnswerFront.Controls.Add(this.lblD);
            this.pnlAnswerFront.Controls.Add(this.lblC);
            this.pnlAnswerFront.Controls.Add(this.lblB);
            this.pnlAnswerFront.Controls.Add(this.lblA);
            this.pnlAnswerFront.Location = new System.Drawing.Point(10, 10);
            this.pnlAnswerFront.Name = "pnlAnswerFront";
            this.pnlAnswerFront.Size = new System.Drawing.Size(1520, 330);
            this.pnlAnswerFront.TabIndex = 0;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA.ForeColor = System.Drawing.SystemColors.Window;
            this.lblA.Location = new System.Drawing.Point(45, 36);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(74, 49);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "A)";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgTime
            // 
            this.prgTime.BackColor = System.Drawing.SystemColors.WindowText;
            this.prgTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prgTime.Location = new System.Drawing.Point(624, 406);
            this.prgTime.Maximum = 450;
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(360, 50);
            this.prgTime.TabIndex = 15;
            this.prgTime.Value = 450;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblB.ForeColor = System.Drawing.SystemColors.Window;
            this.lblB.Location = new System.Drawing.Point(45, 106);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(74, 49);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "B)";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblC.Location = new System.Drawing.Point(45, 176);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(74, 49);
            this.lblC.TabIndex = 17;
            this.lblC.Text = "C)";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblD.ForeColor = System.Drawing.SystemColors.Window;
            this.lblD.Location = new System.Drawing.Point(45, 246);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(74, 49);
            this.lblD.TabIndex = 18;
            this.lblD.Text = "D)";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.ForeColor = System.Drawing.Color.Gold;
            this.lblPoints.Location = new System.Drawing.Point(670, 28);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(260, 73);
            this.lblPoints.TabIndex = 16;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionA.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionA.Location = new System.Drawing.Point(125, 36);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(230, 49);
            this.lblOptionA.TabIndex = 19;
            this.lblOptionA.Text = "Answer A";
            this.lblOptionA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionB.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionB.Location = new System.Drawing.Point(125, 106);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(230, 49);
            this.lblOptionB.TabIndex = 20;
            this.lblOptionB.Text = "Answer B";
            this.lblOptionB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionC.Location = new System.Drawing.Point(125, 176);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(230, 49);
            this.lblOptionC.TabIndex = 21;
            this.lblOptionC.Text = "Answer C";
            this.lblOptionC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Courier New", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionD.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionD.Location = new System.Drawing.Point(125, 246);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(230, 49);
            this.lblOptionD.TabIndex = 22;
            this.lblOptionD.Text = "Answer D";
            this.lblOptionD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.prgTime);
            this.Controls.Add(this.pnlAnswerBack);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.picLife);
            this.Controls.Add(this.lblClose);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).EndInit();
            this.pnlAnswerBack.ResumeLayout(false);
            this.pnlAnswerFront.ResumeLayout(false);
            this.pnlAnswerFront.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picLife;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlAnswerBack;
        private System.Windows.Forms.Panel pnlAnswerFront;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionB;
    }
}