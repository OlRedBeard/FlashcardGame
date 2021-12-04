using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class GameMenuLarge : Form
    {
        public bool sound;
        Form1 previousFrm;
        GameSettings gs;

        public GameMenuLarge(GameSettings settings, Form1 frm)
        {
            InitializeComponent();
            sound = settings.getSound();
            previousFrm = frm;
            gs = settings;

            if (settings.decks != null)
            {
                foreach (FlashcardSet set in settings.decks)
                {
                    cboCardSet.Items.Add(set._title);
                }

                if (cboCardSet.Items.Count > 0)
                    cboCardSet.SelectedIndex = 0;
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            previousFrm.Show();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            previousFrm.Close();
        }

        private void lblAddCards_Click(object sender, EventArgs e)
        {
            UploadSet up = new UploadSet(gs);
            up.ShowDialog();

            if (gs.decks != null)
            {
                foreach (FlashcardSet set in gs.decks)
                {
                    cboCardSet.Items.Add(set._title);
                }

                if (cboCardSet.Items.Count > 0)
                    cboCardSet.SelectedIndex = 0;
            }
        }
    }
}
