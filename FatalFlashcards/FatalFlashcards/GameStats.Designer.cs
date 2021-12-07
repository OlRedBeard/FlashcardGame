
namespace FatalFlashcards
{
    partial class GameStats
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.lblCardsDone = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblBestTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblBestTime);
            this.panel1.Controls.Add(this.lblHighScore);
            this.panel1.Controls.Add(this.lblCardsDone);
            this.panel1.Controls.Add(this.lblRunTime);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 430);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(100, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(580, 70);
            this.label3.TabIndex = 0;
            this.label3.Text = "Run Statistics";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points Earned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(115, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cards Completed:";
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(532, 126);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(134, 33);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "350000";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRunTime
            // 
            this.lblRunTime.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRunTime.Location = new System.Drawing.Point(532, 171);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(134, 33);
            this.lblRunTime.TabIndex = 5;
            this.lblRunTime.Text = "350000";
            this.lblRunTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCardsDone
            // 
            this.lblCardsDone.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardsDone.Location = new System.Drawing.Point(532, 216);
            this.lblCardsDone.Name = "lblCardsDone";
            this.lblCardsDone.Size = new System.Drawing.Size(134, 33);
            this.lblCardsDone.TabIndex = 6;
            this.lblCardsDone.Text = "350000";
            this.lblCardsDone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHighScore
            // 
            this.lblHighScore.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.ForeColor = System.Drawing.Color.Green;
            this.lblHighScore.Location = new System.Drawing.Point(110, 273);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(560, 33);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "NEW HIGH SCORE!";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore.Visible = false;
            // 
            // lblBestTime
            // 
            this.lblBestTime.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBestTime.ForeColor = System.Drawing.Color.Green;
            this.lblBestTime.Location = new System.Drawing.Point(110, 306);
            this.lblBestTime.Name = "lblBestTime";
            this.lblBestTime.Size = new System.Drawing.Size(560, 33);
            this.lblBestTime.TabIndex = 8;
            this.lblBestTime.Text = "NEW BEST TIME!";
            this.lblBestTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBestTime.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(280, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "DONE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // GameStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameStats";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCardsDone;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBestTime;
        private System.Windows.Forms.Label lblHighScore;
    }
}