using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//file system
using System.IO;
//binary formatter
using System.Runtime.Serialization.Formatters.Binary;

namespace FatalFlashcards
{
    public partial class GameMenuLarge : Form
    {
        public bool sound;
        //Form1 previousFrm;
        GameSettings gs;
        FlashcardSet set;

        public GameMenuLarge(GameSettings settings)//, Form1 frm)
        {
            InitializeComponent();
            sound = settings.getSound();
            //previousFrm = frm;
            gs = settings;

            //save game settings for next time
            using (Stream stream = File.Open("settings.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, gs);
                //for testing
                //MessageBox.Show("Game Settings Saved");
            }

            if (settings.decks != null)
            {
                foreach (FlashcardSet set in settings.decks)
                {
                    cboCardSet.Items.Add(set);
                }

                if (cboCardSet.Items.Count > 0)
                    cboCardSet.SelectedIndex = 0;

                if (cboCardSet.SelectedItem != null)
                {
                    set = (FlashcardSet)cboCardSet.SelectedItem;

                    lblBestPoints.Visible = true;
                    lblPoints.Visible = true;
                    if (set.highScore > 0)
                        lblPoints.Text = set.highScore.ToString();
                    else
                        lblPoints.Text = "N/A";

                    lblBestSpeed.Visible = true;
                    lblSpeed.Visible = true;
                    if (set.fastestRun != null)
                        lblSpeed.Text = set.fastestRun;
                    else
                        lblSpeed.Text = "N/A";

                    if (set._donePile.Count > 0)
                        lblPlay.Text = "Continue";
                }
                else
                {
                    lblBestPoints.Visible = false;
                    lblPoints.Visible = false;
                    lblBestSpeed.Visible = false;
                    lblSpeed.Visible = false;
                }
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddCards_Click(object sender, EventArgs e)
        {
            UploadSet up = new UploadSet(gs);
            up.ShowDialog();

            if (gs.decks != null)
            {
                foreach (FlashcardSet set in gs.decks)
                {
                    cboCardSet.Items.Add(set);
                }

                if (cboCardSet.Items.Count > 0)
                    cboCardSet.SelectedIndex = 0;
            }

            //save game settings for next time
            using (Stream stream = File.Open("settings.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, gs);
                //for testing
                MessageBox.Show("Game Settings Saved");
            }
        }

        private void cboCardSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                set = (FlashcardSet)cboCardSet.SelectedItem;
                lblBestPoints.Visible = true;
                lblPoints.Visible = true;
                if (set.highScore > 0)
                    lblPoints.Text = set.highScore.ToString();
                else
                    lblPoints.Text = "N/A";

                lblBestSpeed.Visible = true;
                lblSpeed.Visible = true;
                if (set.fastestRun != null)
                    lblSpeed.Text = set.fastestRun;
                else
                    lblSpeed.Text = "N/A";

                if (set._donePile.Count > 0)
                    lblPlay.Text = "Continue";
                else
                    lblPlay.Text = "Begin";
            }
            catch (Exception ex)
            {
                //for testing
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameWindow game = new GameWindow(gs, this, set);
            game.ShowDialog();
            this.Show();

            if (cboCardSet.SelectedItem != null)
            {
                set = (FlashcardSet)cboCardSet.SelectedItem;

                lblBestPoints.Visible = true;
                lblPoints.Visible = true;
                if (set.highScore > 0)
                    lblPoints.Text = set.highScore.ToString();
                else
                    lblPoints.Text = "N/A";

                lblBestSpeed.Visible = true;
                lblSpeed.Visible = true;
                if (set.fastestRun != null)
                    lblSpeed.Text = set.fastestRun;
                else
                    lblSpeed.Text = "N/A";

                if (set._donePile.Count > 0)
                    lblPlay.Text = "Continue";
            }
            else
            {
                lblBestPoints.Visible = false;
                lblPoints.Visible = false;
                lblBestSpeed.Visible = false;
                lblSpeed.Visible = false;
            }
        }

        private void HoverText(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.ForeColor = Color.Red;
        }

        private void LeaveText(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.ForeColor = Color.White;
        }
    }
}
