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
        private int _Lives;
        //private Form1 _previousFrm;
        public List<FlashcardSet> decks = new List<FlashcardSet>();

        public GameSettings(bool sound)
        {
            this._Sound = sound;
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
        }

        public void AddSet(FlashcardSet tmp)
        {
            decks.Add(tmp);
        }

        public int GetLives()
        {
            return this._Lives;
        }

        public void SetLives(int num)
        {
            this._Lives = num;
        }

        public void LoseLife()
        {
            this._Lives -= 1;
        }
    }
}
