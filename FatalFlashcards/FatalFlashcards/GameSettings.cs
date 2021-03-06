using System;
using System.Collections.Generic;
using System.Text;

namespace FatalFlashcards
{
    [Serializable]
    public class GameSettings
    {
        private bool _Sound;
        private bool _Large;
        //private Form1 _previousFrm;
        public List<FlashcardSet> decks = new List<FlashcardSet>();

        public GameSettings(bool sound)
        {
            this._Sound = sound;
        }

        public void SetSound(bool soundOn)
        {
            this._Sound = soundOn;
        }

        public bool getSound()
        {
            return this._Sound;
        }

        public bool getSize()
        {
            return this._Large;
        }

        public void MakeGame_Large()
        {
            this._Large = true;
            GameMenuLarge menu = new GameMenuLarge(this);
            menu.ShowDialog();
        }

        public void MakeGame_Small()
        {
            this._Large = false;
            GameMenuSmall menu = new GameMenuSmall(this);
            menu.ShowDialog();
        }

        public void AddSet(FlashcardSet tmp)
        {
            decks.Add(tmp);
        }
    }
}
