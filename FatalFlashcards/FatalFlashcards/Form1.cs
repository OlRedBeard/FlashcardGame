using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class Form1 : Form
    {
        public bool gameSound;
        public bool isLarge;
        GameSettings gs;

        public Form1()
        {
            InitializeComponent();

            //implement default game attributes
            gameSound = true;
            isLarge = true;
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            gs = new GameSettings(gameSound, this);

            if (isLarge)
                gs.MakeGame_Large();
            else
                gs.MakeGame_Small();

            this.Hide();
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
