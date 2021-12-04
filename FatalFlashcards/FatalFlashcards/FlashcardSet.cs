using System;
using System.Collections.Generic;
using System.Text;

namespace FatalFlashcards
{
    [Serializable]
    public class FlashcardSet
    {
        Random rnd = new Random();
        public string _title;
        public List<Flashcard> _flashcards;

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
            for(int i = 0; i < 1000; i++)
            {
                int position1 = rnd.Next(1, this._flashcards.Count);
                int position2 = rnd.Next(1, this._flashcards.Count);
            }
        }

        public void ChangeTitle(string newTitle)
        {
            this._title = newTitle;
        }
    }
}
