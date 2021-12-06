using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class GameWindow : Form
    {
        FlashcardSet deck = null;
        Flashcard currQues = null;
        Stopwatch stopwatch = new Stopwatch();
        GameSettings gs;
        GameMenuLarge previousForm;
        private int _Lives;
        private int _Score;

        public GameWindow(GameSettings settings, GameMenuLarge menu, FlashcardSet set)
        {
            InitializeComponent();
            deck = set;
            gs = settings;
            previousForm = menu;

            this._Lives = deck._flashcards.Count / 2;

            if (this._Lives > 50)
                this._Lives = 50;

            if (deck._drawPile == null || deck._drawPile.Count <= 0)
            {
                foreach (Flashcard card in deck._flashcards)
                {
                    card.Shuffle();
                }

                deck.ShuffleCards(deck._flashcards);
                deck.PrepCards();
            }

            lblLives.Text = this._Lives.ToString();

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
            stopwatch.Start();

            lblContinue.Visible = false;
            lblRightWrong.Visible = false;

            if (lblContinue.Text == "Ready >")
            {
                lblContinue.Text = "Next Card >";
            }

            if (deck._drawPile.Count <= 0)
            {
                lblContinue.Visible = false;
            }

            timer1.Enabled = true;

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
            lblOptionC.Text = currQues._AllAnswers[2];
            lblOptionD.Text = currQues._AllAnswers[3];
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();

            Label tmp = (Label)sender;
            if (currQues.CorrectAnswer(tmp.Text))
            {
                lblRightWrong.Visible = true;
                lblRightWrong.ForeColor = Color.Green;
                lblRightWrong.Text = "Correct!";
                this._Score += 50 + prgTime.Value;
                lblPoints.Text = this._Score.ToString();
                deck.SetScore(this._Score);
            }
            else
            {
                lblRightWrong.Visible = true;
                lblRightWrong.ForeColor = Color.Red;
                lblRightWrong.Text = "Incorrect!";
                this._Lives -= 1;
                lblLives.Text = this._Lives.ToString();
            }

            lblQuestion.Visible = false;
            lblContinue.Visible = true;
            timer1.Enabled = false;
            prgTime.Value = 450;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgTime.Value > 0)
                prgTime.Value -= 10;
        }
    }
}
