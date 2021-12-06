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
        public List<Flashcard> _drawPile = new List<Flashcard>();
        public List<Flashcard> _donePile = new List<Flashcard>();

        //attributes for serialization
        public int highScore;
        public int shortestTimeElapsed;
        public string fastestRun = null;

        public FlashcardSet(string title)
        {
            this._title = title;
        }

        public void AddFlashcard(Flashcard flash)
        {
            this._flashcards.Add(flash);
        }

        public void ShuffleCards(List<Flashcard> list)
        {
            for(int i = 0; i < 10000; i++)
            {
                int position1 = rnd.Next(1, this._flashcards.Count);
                int position2 = rnd.Next(1, this._flashcards.Count);

                Flashcard tmp = this._flashcards[position1];
                this._flashcards[position1] = this._flashcards[position2];
                this._flashcards[position2] = tmp;
            }
        }

        public void ChangeTitle(string newTitle)
        {
            this._title = newTitle;
        }

        public void SetHighScore(int score)
        {
            if (score > this.highScore)
                this.highScore = score;
        }

        public void SetFastestRun(int timeElapsed)
        {
            if (timeElapsed < this.shortestTimeElapsed)
            {
                int minutes = timeElapsed / 60;
                int seconds = timeElapsed % 60;

                this.fastestRun = minutes.ToString() + ":" + seconds.ToString();
            }
        }

        public void PrepCards()
        {
            foreach (Flashcard card in this._flashcards)
            {
                this._drawPile.Add(card);
            }
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
    }
}
