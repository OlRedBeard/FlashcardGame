using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class UploadTutorial : Form
    {
        public UploadTutorial()
        {
            InitializeComponent();
        }

        private void lblDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDone_MouseHover(object sender, EventArgs e)
        {
            lblDone.ForeColor = Color.Red;
        }

        private void lblDone_MouseLeave(object sender, EventArgs e)
        {
            lblDone.ForeColor = Color.White;
        }
    }
}
