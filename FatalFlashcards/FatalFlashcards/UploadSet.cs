using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class UploadSet : Form
    {
        FlashcardSet newSet;
        GameSettings gs;

        public UploadSet(GameSettings settings)
        {
            InitializeComponent();

            gs = settings;
            newSet = new FlashcardSet("Untitled");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Pipe Separated Values (*.psv)|*.psv";
            string[] fileLines;

            if (op.ShowDialog() == DialogResult.OK)
            {
                lblFilepath.Text = op.FileName;

                fileLines = File.ReadAllLines(op.FileName);
                foreach (string line in fileLines)
                {
                    Flashcard tmp = new Flashcard(line);
                    tmp.Shuffle();
                    newSet.AddFlashcard(tmp);
                }
            }
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != null && txtTitle.Text != "")
                newSet.ChangeTitle(txtTitle.Text);

            if (newSet != null)
                gs.decks.Add(newSet);
        }
    }
}
