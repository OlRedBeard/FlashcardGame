using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class GameWindow : Form
    {
        FlashcardSet deck;
        Flashcard currQues = null;
        GameSettings gs;
        GameMenuLarge previousForm;

        public GameWindow(GameSettings settings, GameMenuLarge menu, FlashcardSet set)
        {
            InitializeComponent();
            deck = set;
            gs = settings;
            previousForm = menu;

            if (deck._drawPile.Count > 0)
            {
                foreach (Flashcard card in deck._flashcards)
                {
                    card.Shuffle();
                }

                deck.ShuffleCards(deck._flashcards);
            }

            lblQuestion.Text = "Click 'Ready' below to begin.";
            //question answer labels
            lblA.Visible = false;
            lblB.Visible = false;
            lblC.Visible = false;
            lblD.Visible = false;
            lblOptionA.Visible = false;
            lblOptionB.Visible = false;
            lblOptionC.Visible = false;
            lblOptionD.Visible = false;
            //continue/begin label
            lblContinue.Text = "Ready >";
            lblContinue.Visible = true;
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            lblContinue.Visible = false;
            lblRightWrong.Visible = false;

            if (lblContinue.Text == "Ready >")
            {
                lblContinue.Text = "Next Card >";
            }

            //question answer labels
            lblQuestion.Visible = true;
            lblA.Visible = true;
            lblB.Visible = true;
            lblC.Visible = true;
            lblD.Visible = true;
            lblOptionA.Visible = true;
            lblOptionB.Visible = true;
            lblOptionC.Visible = true;
            lblOptionD.Visible = true;

            currQues = deck.DrawCard();
            lblQuestion.Text = currQues.GetQuestion();
            lblOptionA.Text = currQues._AllAnswers[0];
            lblOptionB.Text = currQues._AllAnswers[1];
            lblOptionB.Text = currQues._AllAnswers[2];
            lblOptionB.Text = currQues._AllAnswers[3];
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            if (currQues.CorrectAnswer(tmp.Text))
            {
                lblRightWrong.Visible = true;
                lblRightWrong.ForeColor = Color.Green;
                lblRightWrong.Text = "Correct!";
            }
            else
            {
                lblRightWrong.Visible = true;
                lblRightWrong.ForeColor = Color.Red;
                lblRightWrong.Text = "Incorrect!";
            }

            lblQuestion.Visible = false;
            lblContinue.Visible = true;
        }
    }
}
