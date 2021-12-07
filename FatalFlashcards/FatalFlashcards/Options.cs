using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class Options : Form
    {
        Form1 previousForm;

        public Options(Form1 frm)
        {
            InitializeComponent();

            previousForm = frm;

            if (previousForm.gameSound)
                lblSoundStat.Text = "On";
            else
                lblSoundStat.Text = "Off";
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void lblSizeRight_Click(object sender, EventArgs e)
        {
            if (lblSize.Text == "1600 x 900")
                lblSize.Text = "800 x 450";
            else
                lblSize.Text = "1600 x 900";
        }

        private void lblSizeLeft_Click(object sender, EventArgs e)
        {
            if (lblSize.Text == "1600 x 900")
                lblSize.Text = "800 x 450";
            else
                lblSize.Text = "1600 x 900";
        }

        private void lblSoundRight_Click(object sender, EventArgs e)
        {
            if (lblSoundStat.Text == "On")
                lblSoundStat.Text = "Off";
            else
                lblSoundStat.Text = "On";
        }

        private void lblSoundLeft_Click(object sender, EventArgs e)
        {
            if (lblSoundStat.Text == "On")
                lblSoundStat.Text = "Off";
            else
                lblSoundStat.Text = "On";
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.Window;
        }

        private void lblSizeRight_MouseHover(object sender, EventArgs e)
        {
            lblSizeRight.ForeColor = Color.Red;
        }

        private void lblSizeRight_MouseLeave(object sender, EventArgs e)
        {
            lblSizeRight.ForeColor = SystemColors.Window;
        }

        private void lblSizeLeft_MouseHover(object sender, EventArgs e)
        {
            lblSizeLeft.ForeColor = Color.Red;
        }

        private void lblSizeLeft_MouseLeave(object sender, EventArgs e)
        {
            lblSizeLeft.ForeColor = SystemColors.Window;
        }

        private void lblSoundRight_MouseHover(object sender, EventArgs e)
        {
            lblSoundRight.ForeColor = Color.Red;
        }

        private void lblSoundRight_MouseLeave(object sender, EventArgs e)
        {
            lblSoundRight.ForeColor = SystemColors.Window;
        }

        private void lblSoundLeft_MouseHover(object sender, EventArgs e)
        {
            lblSoundLeft.ForeColor = Color.Red;
        }

        private void lblSoundLeft_MouseLeave(object sender, EventArgs e)
        {
            lblSoundLeft.ForeColor = SystemColors.Window;
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            //logic to send size & sound preferences to config/class file
            if (lblSize.Text == "1600 x 900")
            {
                previousForm.isLarge = true;
            }
            else
            {
                previousForm.isLarge = false;
            }

            if (lblSoundStat.Text == "On")
                previousForm.gameSound = true;
            else
                previousForm.gameSound = false;

            //close the form and return
            this.Close();
            previousForm.Show();
        }

        private void lblConfirm_MouseHover(object sender, EventArgs e)
        {
            lblConfirm.ForeColor = Color.Red;
        }

        private void lblConfirm_MouseLeave(object sender, EventArgs e)
        {
            lblConfirm.ForeColor = SystemColors.Window;
        }
    }
}
