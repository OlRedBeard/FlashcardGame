using System;
using System.Collections.Generic;
using System.Text;

namespace FatalFlashcards
{
    [Serializable]
    public class GameSettings
    {
        private bool _Sound;
        private Form1 _previousFrm;
        public List<FlashcardSet> decks;

        public GameSettings(bool sound, Form1 prev)
        {
            this._Sound = sound;
            this._previousFrm = prev;
        }

        public bool getSound()
        {
            return this._Sound;
        }

        public void MakeGame_Large()
        {
            GameMenuLarge menu = new GameMenuLarge(this, _previousFrm);
        }

        public void MakeGame_Small()
        {

        }

        public void AddSet(FlashcardSet tmp)
        {
            decks.Add(tmp);
        }
    }
}
