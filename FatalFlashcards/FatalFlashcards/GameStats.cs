using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class GameStats : Form
    {
        GameWindow previousForm;

        public GameStats(GameWindow prev, int points, string time, decimal percentage, bool highScore, bool fastestRun)
        {
            InitializeComponent();

            previousForm = prev;
            //cannot format this decimal with the tostring or it breaks
            lblCardsDone.Text = percentage.ToString() + "%";
            lblPoints.Text = points.ToString();
            lblRunTime.Text = time;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Close();
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }
    }
}
