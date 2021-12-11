using System;
using System.Collections.Generic;
using System.Text;

namespace FatalFlashcards
{
    [Serializable]
    public class FlashcardSet
    {
        static Random rnd = new Random();
        public string _title;
        public List<Flashcard> _flashcards = new List<Flashcard>();

        //draw & done lists for progress info
        public List<Flashcard> _drawPile;
        public List<Flashcard> _donePile = new List<Flashcard>();

        //attributes for serialization
        public int highScore;
        public int currScore;
        public int shortestTimeElapsed;
        public string fastestRun;
        public string timeRun;
        public int numLives;
        public decimal correctAnswers;
        public decimal totalCards;
        public decimal percentageCorrect;
        public int bestPercentage;

        public FlashcardSet(string title)
        {
            this._title = title;
            this.bestPercentage = 0;
            this._drawPile = new List<Flashcard>();
        }

        public void AddFlashcard(Flashcard flash)
        {
            this._flashcards.Add(flash);
        }

        public void ShuffleCards(List<Flashcard> list)
        {
            for(int i = 0; i < 10000; i++)
            {
                int position1 = rnd.Next(0, this._flashcards.Count);
                int position2 = rnd.Next(0, this._flashcards.Count);

                Flashcard tmp = this._flashcards[position1];
                this._flashcards[position1] = this._flashcards[position2];
                this._flashcards[position2] = tmp;
            }
        }

        public void ChangeTitle(string newTitle)
        {
            this._title = newTitle;
        }

        public void SetScore(int score)
        {
            if (score > this.highScore)
            {
                this.highScore = score;
            }

            this.currScore = score;
        }

        public void SetFastestRun(int timeElapsed)
        {
            //this is still firing even if the new time is longer than before
            if (timeElapsed < this.shortestTimeElapsed || this.shortestTimeElapsed == 0)
            {
                if (timeElapsed > 60)
                {
                    int minutes = timeElapsed / 60;
                    int seconds = timeElapsed % 60;
                    this.fastestRun = minutes.ToString("D2") + ":" + seconds.ToString("D2");
                    this.timeRun = minutes.ToString("D2") + ":" + seconds.ToString("D2");
                    this.shortestTimeElapsed = timeElapsed;
                }
                else
                {
                    int seconds = timeElapsed;
                    this.fastestRun = "00:" + seconds.ToString("D2");
                    this.timeRun = "00:" + seconds.ToString("D2");
                    this.shortestTimeElapsed = timeElapsed;
                }
            }
            else
            {
                int minutes = timeElapsed / 60;
                int seconds = timeElapsed % 60;

                this.timeRun = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }
        }

        public void PrepCards()
        {
            this._drawPile.Clear();

            foreach (Flashcard card in this._flashcards)
            {
                this._drawPile.Add(card);
            }

            this.totalCards = this._drawPile.Count;
        }

        public Flashcard DrawCard()
        {
            Flashcard tmp = null;

            if (this._drawPile.Count > 0)
            {
                tmp = this._drawPile[0];
                this._drawPile.RemoveAt(0);
            }

            return tmp;
        }

        public void DoneCard(Flashcard card)
        {
            this._donePile.Add(card);
        }

        public int CardsRemaining()
        {
            return this._drawPile.Count;
        }

        public override string ToString()
        {
            return this._title;
        }

        public void RestockCards()
        {
            //something is not right here, the done pile is growing
            _donePile.Clear();
            _drawPile.Clear();
            this.correctAnswers = 0;
        }

        public int GetLives()
        {
            return this.numLives;
        }

        public void SetLives(int num)
        {
            this.numLives = num;
        }

        public void LoseLife()
        {
            this.numLives -= 1;
        }

        public void CorrectAnswer()
        {
            this.correctAnswers += 1;
        }

        public int GetPercentage()
        {
            decimal percentage;
            percentage = (this.correctAnswers / this.totalCards) * 100;
            int ret = Convert.ToInt32(percentage);

            if (ret > this.bestPercentage)
                SetBestPercentage(ret);

            return ret;
        }

        public void SetBestPercentage(int per)
        {
            this.bestPercentage = per;
        }

        public int GetBestPercentage()
        {
            return this.bestPercentage;
        }
    }
}
