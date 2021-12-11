
namespace FatalFlashcards
{
    partial class Options
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizeRight = new System.Windows.Forms.Label();
            this.lblSizeLeft = new System.Windows.Forms.Label();
            this.lblSoundLeft = new System.Windows.Forms.Label();
            this.lblSoundRight = new System.Windows.Forms.Label();
            this.lblSoundStat = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClose.Location = new System.Drawing.Point(756, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 33);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(0, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 100);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Options";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Window Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSize.Location = new System.Drawing.Point(300, 167);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(200, 44);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "1600 x 900";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSizeRight
            // 
            this.lblSizeRight.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSizeRight.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSizeRight.Location = new System.Drawing.Point(510, 167);
            this.lblSizeRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblSizeRight.Name = "lblSizeRight";
            this.lblSizeRight.Size = new System.Drawing.Size(200, 44);
            this.lblSizeRight.TabIndex = 8;
            this.lblSizeRight.Text = ">";
            this.lblSizeRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSizeRight.Click += new System.EventHandler(this.lblSizeRight_Click);
            this.lblSizeRight.MouseLeave += new System.EventHandler(this.lblSizeRight_MouseLeave);
            this.lblSizeRight.MouseHover += new System.EventHandler(this.lblSizeRight_MouseHover);
            // 
            // lblSizeLeft
            // 
            this.lblSizeLeft.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSizeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSizeLeft.Location = new System.Drawing.Point(90, 167);
            this.lblSizeLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblSizeLeft.Name = "lblSizeLeft";
            this.lblSizeLeft.Size = new System.Drawing.Size(200, 44);
            this.lblSizeLeft.TabIndex = 9;
            this.lblSizeLeft.Text = "<";
            this.lblSizeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSizeLeft.Click += new System.EventHandler(this.lblSizeLeft_Click);
            this.lblSizeLeft.MouseLeave += new System.EventHandler(this.lblSizeLeft_MouseLeave);
            this.lblSizeLeft.MouseHover += new System.EventHandler(this.lblSizeLeft_MouseHover);
            // 
            // lblSoundLeft
            // 
            this.lblSoundLeft.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoundLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoundLeft.Location = new System.Drawing.Point(90, 274);
            this.lblSoundLeft.Margin = new System.Windows.Forms.Padding(0);
            this.lblSoundLeft.Name = "lblSoundLeft";
            this.lblSoundLeft.Size = new System.Drawing.Size(200, 44);
            this.lblSoundLeft.TabIndex = 12;
            this.lblSoundLeft.Text = "<";
            this.lblSoundLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSoundLeft.Click += new System.EventHandler(this.lblSoundLeft_Click);
            this.lblSoundLeft.MouseLeave += new System.EventHandler(this.lblSoundLeft_MouseLeave);
            this.lblSoundLeft.MouseHover += new System.EventHandler(this.lblSoundLeft_MouseHover);
            // 
            // lblSoundRight
            // 
            this.lblSoundRight.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoundRight.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoundRight.Location = new System.Drawing.Point(510, 274);
            this.lblSoundRight.Margin = new System.Windows.Forms.Padding(0);
            this.lblSoundRight.Name = "lblSoundRight";
            this.lblSoundRight.Size = new System.Drawing.Size(200, 44);
            this.lblSoundRight.TabIndex = 11;
            this.lblSoundRight.Text = ">";
            this.lblSoundRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoundRight.Click += new System.EventHandler(this.lblSoundRight_Click);
            this.lblSoundRight.MouseLeave += new System.EventHandler(this.lblSoundRight_MouseLeave);
            this.lblSoundRight.MouseHover += new System.EventHandler(this.lblSoundRight_MouseHover);
            // 
            // lblSoundStat
            // 
            this.lblSoundStat.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoundStat.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSoundStat.Location = new System.Drawing.Point(300, 274);
            this.lblSoundStat.Margin = new System.Windows.Forms.Padding(0);
            this.lblSoundStat.Name = "lblSoundStat";
            this.lblSoundStat.Size = new System.Drawing.Size(200, 44);
            this.lblSoundStat.TabIndex = 10;
            this.lblSoundStat.Text = "On";
            this.lblSoundStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSound
            // 
            this.lblSound.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSound.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSound.Location = new System.Drawing.Point(20, 230);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(760, 44);
            this.lblSound.TabIndex = 13;
            this.lblSound.Text = "Sound";
            this.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.lblConfirm.Location = new System.Drawing.Point(20, 353);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(760, 44);
            this.lblConfirm.TabIndex = 14;
            this.lblConfirm.Text = "Confirm Changes";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            this.lblConfirm.MouseLeave += new System.EventHandler(this.lblConfirm_MouseLeave);
            this.lblConfirm.MouseHover += new System.EventHandler(this.lblConfirm_MouseHover);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblSoundLeft);
            this.Controls.Add(this.lblSoundRight);
            this.Controls.Add(this.lblSoundStat);
            this.Controls.Add(this.lblSizeLeft);
            this.Controls.Add(this.lblSizeRight);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeRight;
        private System.Windows.Forms.Label lblSizeLeft;
        private System.Windows.Forms.Label lblSoundLeft;
        private System.Windows.Forms.Label lblSoundRight;
        private System.Windows.Forms.Label lblSoundStat;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblConfirm;
    }
}