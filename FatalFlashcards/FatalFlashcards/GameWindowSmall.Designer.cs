
namespace FatalFlashcards
{
    partial class GameWindowSmall
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindowSmall));
            this.pnlAnswerFront = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.pnlAnswerBack = new System.Windows.Forms.Panel();
            this.prgTime = new System.Windows.Forms.ProgressBar();
            this.lblLives = new System.Windows.Forms.Label();
            this.picLife = new System.Windows.Forms.PictureBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblRightWrong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlAnswerFront.SuspendLayout();
            this.pnlAnswerBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAnswerFront
            // 
            this.pnlAnswerFront.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnlAnswerFront.Controls.Add(this.lblStats);
            this.pnlAnswerFront.Controls.Add(this.lblWinLose);
            this.pnlAnswerFront.Controls.Add(this.lblContinue);
            this.pnlAnswerFront.Controls.Add(this.lblOptionD);
            this.pnlAnswerFront.Controls.Add(this.lblOptionC);
            this.pnlAnswerFront.Controls.Add(this.lblOptionB);
            this.pnlAnswerFront.Controls.Add(this.lblOptionA);
            this.pnlAnswerFront.Controls.Add(this.lblD);
            this.pnlAnswerFront.Controls.Add(this.lblC);
            this.pnlAnswerFront.Controls.Add(this.lblB);
            this.pnlAnswerFront.Controls.Add(this.lblA);
            this.pnlAnswerFront.Location = new System.Drawing.Point(5, 5);
            this.pnlAnswerFront.Name = "pnlAnswerFront";
            this.pnlAnswerFront.Size = new System.Drawing.Size(760, 150);
            this.pnlAnswerFront.TabIndex = 0;
            // 
            // lblStats
            // 
            this.lblStats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStats.ForeColor = System.Drawing.Color.White;
            this.lblStats.Location = new System.Drawing.Point(270, 80);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(220, 28);
            this.lblStats.TabIndex = 26;
            this.lblStats.Text = "View Run Stats";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStats.Visible = false;
            // 
            // lblWinLose
            // 
            this.lblWinLose.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWinLose.ForeColor = System.Drawing.Color.Red;
            this.lblWinLose.Location = new System.Drawing.Point(250, 40);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(260, 40);
            this.lblWinLose.TabIndex = 25;
            this.lblWinLose.Text = "You Died";
            this.lblWinLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinLose.Visible = false;
            // 
            // lblContinue
            // 
            this.lblContinue.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContinue.ForeColor = System.Drawing.Color.Gold;
            this.lblContinue.Location = new System.Drawing.Point(580, 115);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(167, 37);
            this.lblContinue.TabIndex = 23;
            this.lblContinue.Text = " Next Card >";
            this.lblContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionD.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionD.Location = new System.Drawing.Point(54, 109);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(114, 23);
            this.lblOptionD.TabIndex = 22;
            this.lblOptionD.Text = "Answer D";
            this.lblOptionD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionD.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionC.Location = new System.Drawing.Point(54, 79);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(114, 23);
            this.lblOptionC.TabIndex = 21;
            this.lblOptionC.Text = "Answer C";
            this.lblOptionC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionC.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionB.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionB.Location = new System.Drawing.Point(54, 49);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(114, 23);
            this.lblOptionB.TabIndex = 20;
            this.lblOptionB.Text = "Answer B";
            this.lblOptionB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionB.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptionA.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptionA.Location = new System.Drawing.Point(54, 19);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(114, 23);
            this.lblOptionA.TabIndex = 19;
            this.lblOptionA.Text = "Answer A";
            this.lblOptionA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptionA.Click += new System.EventHandler(this.Answer_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblD.ForeColor = System.Drawing.SystemColors.Window;
            this.lblD.Location = new System.Drawing.Point(12, 109);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(36, 23);
            this.lblD.TabIndex = 18;
            this.lblD.Text = "D)";
            this.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblC.Location = new System.Drawing.Point(12, 79);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 23);
            this.lblC.TabIndex = 17;
            this.lblC.Text = "C)";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblB.ForeColor = System.Drawing.SystemColors.Window;
            this.lblB.Location = new System.Drawing.Point(12, 49);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(36, 23);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "B)";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblA.ForeColor = System.Drawing.SystemColors.Window;
            this.lblA.Location = new System.Drawing.Point(12, 19);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(36, 23);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "A)";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnswerBack
            // 
            this.pnlAnswerBack.BackColor = System.Drawing.SystemColors.Window;
            this.pnlAnswerBack.Controls.Add(this.pnlAnswerFront);
            this.pnlAnswerBack.Location = new System.Drawing.Point(15, 278);
            this.pnlAnswerBack.Name = "pnlAnswerBack";
            this.pnlAnswerBack.Size = new System.Drawing.Size(770, 160);
            this.pnlAnswerBack.TabIndex = 15;
            // 
            // prgTime
            // 
            this.prgTime.BackColor = System.Drawing.SystemColors.WindowText;
            this.prgTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prgTime.Location = new System.Drawing.Point(310, 233);
            this.prgTime.Maximum = 450;
            this.prgTime.Name = "prgTime";
            this.prgTime.Size = new System.Drawing.Size(180, 25);
            this.prgTime.TabIndex = 27;
            this.prgTime.Value = 450;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLives.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLives.Location = new System.Drawing.Point(68, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(34, 36);
            this.lblLives.TabIndex = 29;
            this.lblLives.Text = "0";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLife
            // 
            this.picLife.Image = ((System.Drawing.Image)(resources.GetObject("picLife.Image")));
            this.picLife.Location = new System.Drawing.Point(12, 6);
            this.picLife.Name = "picLife";
            this.picLife.Size = new System.Drawing.Size(50, 50);
            this.picLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife.TabIndex = 28;
            this.picLife.TabStop = false;
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.ForeColor = System.Drawing.Color.Gold;
            this.lblPoints.Location = new System.Drawing.Point(270, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(260, 36);
            this.lblPoints.TabIndex = 30;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClose.Location = new System.Drawing.Point(765, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 31;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuestion.Location = new System.Drawing.Point(80, 57);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(640, 163);
            this.lblQuestion.TabIndex = 32;
            this.lblQuestion.Text = resources.GetString("lblQuestion.Text");
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrect
            // 
            this.lblCorrect.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCorrect.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCorrect.Location = new System.Drawing.Point(1, 154);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(800, 28);
            this.lblCorrect.TabIndex = 34;
            this.lblCorrect.Text = "Answer A";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCorrect.Visible = false;
            // 
            // lblRightWrong
            // 
            this.lblRightWrong.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRightWrong.ForeColor = System.Drawing.Color.Red;
            this.lblRightWrong.Location = new System.Drawing.Point(1, 95);
            this.lblRightWrong.Name = "lblRightWrong";
            this.lblRightWrong.Size = new System.Drawing.Size(800, 56);
            this.lblRightWrong.TabIndex = 33;
            this.lblRightWrong.Text = "Incorrect";
            this.lblRightWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRightWrong.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameWindowSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblRightWrong);
            this.Controls.Add(this.prgTime);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.picLife);
            this.Controls.Add(this.pnlAnswerBack);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindowSmall";
            this.Text = "GameWindowSmall";
            this.pnlAnswerFront.ResumeLayout(false);
            this.pnlAnswerFront.PerformLayout();
            this.pnlAnswerBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnswerFront;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Panel pnlAnswerBack;
        private System.Windows.Forms.ProgressBar prgTime;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.PictureBox picLife;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblRightWrong;
        private System.Windows.Forms.Timer timer1;
    }
}