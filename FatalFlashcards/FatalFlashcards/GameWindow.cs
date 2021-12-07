﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//file system
using System.IO;
//binary formatter
using System.Runtime.Serialization.Formatters.Binary;

namespace FatalFlashcards
{
    public partial class GameWindow : Form
    {
        FlashcardSet deck = null;
        Flashcard currQues = null;
        Stopwatch stopwatch = new Stopwatch();
        GameSettings gs;
        GameMenuLarge previousForm;
        private int _Score;
        //win/lose data
        string runTime = "N/A";
        bool gotHighScore = false;
        bool gotBestSpeed = false;
        decimal percentage;

        public GameWindow(GameSettings settings, GameMenuLarge menu, FlashcardSet set)
        {
            InitializeComponent();
            deck = set;
            gs = settings;
            previousForm = menu;
            int lives = deck._flashcards.Count / 2;
            if (lives > 50)
                lives = 50;

            //for testing
            //lives = 3;

            gs.SetLives(lives);

            if (deck._drawPile == null || deck._drawPile.Count <= 0)
            {
                foreach (Flashcard card in deck._flashcards)
                {
                    card.Shuffle();
                }

                deck.ShuffleCards(deck._flashcards);
                deck.PrepCards();
            }

            lblLives.Text = gs.GetLives().ToString();

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
            lblCorrect.Visible = false;

            if (lblContinue.Text == "Ready >")
            {
                lblContinue.Text = "Next Card >";
            }

            if (gs.GetLives() == 0)
            {
                lblQuestion.Visible = false;
                lblA.Visible = false;
                lblB.Visible = false;
                lblC.Visible = false;
                lblD.Visible = false;
                lblOptionA.Visible = false;
                lblOptionB.Visible = false;
                lblOptionC.Visible = false;
                lblOptionD.Visible = false;

                lblContinue.Visible = false;
                lblWinLose.Visible = true;
                lblWinLose.ForeColor = Color.Red;
                lblWinLose.Text = "You Died.";
                lblStats.Visible = true;

                percentage = ((decimal)deck._donePile.Count / (decimal)deck._flashcards.Count) * 100;

                runTime = "N/A";

                //save game settings for next time
                using (Stream stream = File.Open("settings.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, gs);
                }

                if (deck.currScore == deck.highScore)
                    gotHighScore = true;
                else
                    gotHighScore = false;

                deck.currScore = 0;

                deck.RestockCards();
            }
            else if (deck._drawPile.Count <= 0)
            {
                lblQuestion.Visible = false;
                lblA.Visible = false;
                lblB.Visible = false;
                lblC.Visible = false;
                lblD.Visible = false;
                lblOptionA.Visible = false;
                lblOptionB.Visible = false;
                lblOptionC.Visible = false;
                lblOptionD.Visible = false;

                lblContinue.Visible = false;
                lblWinLose.Visible = true;
                lblWinLose.ForeColor = Color.Green;
                lblWinLose.Text = "You Win!";
                lblStats.Visible = true;
                deck.SetFastestRun(Convert.ToInt32(stopwatch.ElapsedMilliseconds / 1000));

                runTime = deck.timeRun;

                //save game settings for next time
                using (Stream stream = File.Open("settings.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, gs);
                }

                if (deck.currScore == deck.highScore)
                    gotHighScore = true;

                percentage = 100;

                if (deck.timeRun == deck.fastestRun)
                    gotBestSpeed = true;
                else
                    gotBestSpeed = false;

                deck.currScore = 0;

                deck.RestockCards();
            }
            else
            {
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
                lblCorrect.Visible = true;
                lblCorrect.Text = "Correct answer was: " + currQues.GetCorrectAnswer();
                lblRightWrong.ForeColor = Color.Red;
                lblRightWrong.Text = "Incorrect!";
                gs.LoseLife();
                lblLives.Text = gs.GetLives().ToString();
            }

            lblQuestion.Visible = false;
            lblContinue.Visible = true;
            timer1.Enabled = false;
            prgTime.Value = 450;
            deck.DoneCard(currQues);

            //save game settings for next time
            using (Stream stream = File.Open("settings.bin", FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, gs);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgTime.Value > 0)
                prgTime.Value -= 10;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblStats_Click(object sender, EventArgs e)
        {
            GameStats stats = new GameStats(this, _Score, runTime, percentage, gotHighScore, gotBestSpeed);
            stats.ShowDialog();
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
