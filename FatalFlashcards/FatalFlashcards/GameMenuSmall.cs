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
//media
using System.Media;

namespace FatalFlashcards
{
    public partial class GameMenuSmall : Form
    {
        public bool sound;
        //Form1 previousFrm;
        GameSettings gs;
        FlashcardSet set;

        //sound settings
        SoundPlayer sp;

        public GameMenuSmall(GameSettings settings)
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

            //system media method
            if (sound)
            {
                sp = new SoundPlayer();
                sp.SoundLocation = "ambient horror.wav";
                sp.PlayLooping();
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

                    lblCorrect.Visible = true;
                    lblPercentage.Visible = true;
                    if (set.GetBestPercentage() > 0)
                        lblPercentage.Text = set.GetBestPercentage().ToString() + "%";
                    else
                        lblPercentage.Text = "N/A";

                    if (set._donePile.Count > 0)
                        lblPlay.Text = "Continue";
                }
                else
                {
                    lblBestPoints.Visible = false;
                    lblPoints.Visible = false;
                    lblBestSpeed.Visible = false;
                    lblSpeed.Visible = false;
                    lblCorrect.Visible = false;
                    lblPercentage.Visible = false;
                }
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

                lblCorrect.Visible = true;
                lblPercentage.Visible = true;
                if (set.GetBestPercentage() > 0)
                    lblPercentage.Text = set.GetBestPercentage().ToString() + "%";
                else
                    lblPercentage.Text = "N/A";

                if (set._donePile.Count > 0)
                    lblPlay.Text = "Continue";
                else
                    lblPlay.Text = "Begin";
            }
            catch (Exception ex)
            {
                //for testing
                //MessageBox.Show(ex.ToString());
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (sp != null)
                sp.Stop();

            this.Close();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            if (sp != null)
                sp.Stop();

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

        private void lblPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (sp != null)
                sp.Stop();
            GameWindowSmall game = new GameWindowSmall(gs, this, set);
            game.ShowDialog();
            this.Show();

            if (sound)
                sp.PlayLooping();

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

        private void label1_Click(object sender, EventArgs e)
        {
            UploadTutorial tut = new UploadTutorial();
            tut.ShowDialog();
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
