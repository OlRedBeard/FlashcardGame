using System;
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
//sound settings
using System.Media;
//sound plugin
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

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
        decimal tmpPercentage;
        decimal percentage;
        //sound settings
        SoundPlayer correct;
        SoundPlayer incorrect;
        SoundPlayer win;
        SoundPlayer lose;
        //background sound settings
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        bool stopSound = false;

        public GameWindow(GameSettings settings, GameMenuLarge menu, FlashcardSet set)
        {
            InitializeComponent();
            deck = set;
            gs = settings;
            previousForm = menu;

            if (gs.getSound())
            {
                correct = new SoundPlayer();
                correct.SoundLocation = "Right.wav";
                incorrect = new SoundPlayer();
                incorrect.SoundLocation = "Wrong.wav";
                win = new SoundPlayer();
                win.SoundLocation = "Victory.wav";
                lose = new SoundPlayer();
                lose.SoundLocation = "Failure.wav";

                //nAudio sounds
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }

                if (audioFile == null)
                {
                    audioFile = new AudioFileReader("heartbeat.wav");
                    outputDevice.Init(audioFile);
                }
                outputDevice.Play();
            }

            if (deck._drawPile == null || deck._drawPile.Count <= 0)
            {
                foreach (Flashcard card in deck._flashcards)
                {
                    card.Shuffle();
                }

                deck.ShuffleCards(deck._flashcards);
                deck.PrepCards();

                int lives = deck._flashcards.Count / 2;
                if (lives > 50)
                    lives = 50;

                deck.SetLives(lives);
            }

            lblLives.Text = deck.GetLives().ToString();

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

        //nAudio method
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;

            if (!stopSound)
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }

                if (audioFile == null)
                {
                    audioFile = new AudioFileReader("heartbeat.wav");
                    outputDevice.Init(audioFile);
                }
                outputDevice.Play();
            }
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

            if (deck.GetLives() == 0)
            {
                if (gs.getSound())
                    lose.Play();

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

                tmpPercentage = ((decimal)deck._donePile.Count / (decimal)deck._flashcards.Count) * 100;
                percentage = Math.Round(tmpPercentage, 0);

                runTime = "N/A";

                if (deck.currScore == deck.highScore)
                    gotHighScore = true;
                else
                    gotHighScore = false;

                deck.currScore = 0;

                deck.RestockCards();

                //save game settings for next time
                using (Stream stream = File.Open("settings.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, gs);
                }
            }
            else if (deck._drawPile.Count <= 0)
            {
                if (gs.getSound())
                    win.Play();

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

                if (deck.currScore == deck.highScore)
                    gotHighScore = true;

                percentage = 100;

                if (deck.timeRun == deck.fastestRun)
                    gotBestSpeed = true;
                else
                    gotBestSpeed = false;

                deck.currScore = 0;

                deck.RestockCards();

                //save game settings for next time
                using (Stream stream = File.Open("settings.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, gs);
                }
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
                if (gs.getSound())
                    correct.Play();
            }
            else
            {
                lblRightWrong.Visible = true;
                lblCorrect.Visible = true;
                lblCorrect.Text = "Correct answer was: " + currQues.GetCorrectAnswer();
                lblRightWrong.ForeColor = Color.Red;
                lblRightWrong.Text = "Incorrect!";
                deck.LoseLife();
                lblLives.Text = deck.GetLives().ToString();
                if (gs.getSound())
                    incorrect.Play();
            }

            lblQuestion.Visible = false;
            lblA.Visible = false;
            lblB.Visible = false;
            lblC.Visible = false;
            lblD.Visible = false;
            lblOptionA.Visible = false;
            lblOptionB.Visible = false;
            lblOptionC.Visible = false;
            lblOptionD.Visible = false;

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
            stopSound = true;
            outputDevice?.Stop();
            this.Close();
        }

        private void lblStats_Click(object sender, EventArgs e)
        {
            stopSound = true;
            outputDevice?.Stop();
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
