using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//file system
using System.IO;
//binary formatter
using System.Runtime.Serialization.Formatters.Binary;

namespace FatalFlashcards
{
    [Serializable]
    public partial class Form1 : Form
    {
        public bool fileExists;
        public bool gameSound;
        public bool isLarge;
        GameSettings gs;

        public Form1()
        {
            InitializeComponent();

            //check for existing game settings file
            fileExists = File.Exists("settings.bin");

            if (fileExists)
            {
                using (Stream stream = File.Open("settings.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    gs = (GameSettings)bin.Deserialize(stream);
                    gameSound = gs.getSound();
                    isLarge = gs.getSize();
                    //for testing
                    MessageBox.Show("Game Settings Loaded");
                }
            }

            else
            {
                //implement default game attributes
                gameSound = true;
                isLarge = true;
            }

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            if (!fileExists)
                gs = new GameSettings(gameSound);

            if (isLarge)
            {
                this.Hide();
                gs.MakeGame_Large();
            }
            else
            {
                this.Hide();
                gs.MakeGame_Small();
            }

            this.Show();
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Options op = new Options(this);
            op.ShowDialog();
        }

        private void lblPlay_MouseHover(object sender, EventArgs e)
        {
            lblPlay.ForeColor = Color.Red;
        }

        private void lblPlay_MouseLeave(object sender, EventArgs e)
        {
            lblPlay.ForeColor = SystemColors.Window;
        }

        private void lblOptions_MouseHover(object sender, EventArgs e)
        {
            lblOptions.ForeColor = Color.Red;
        }

        private void lblOptions_MouseLeave(object sender, EventArgs e)
        {
            lblOptions.ForeColor = SystemColors.Window;
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = SystemColors.Window;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
