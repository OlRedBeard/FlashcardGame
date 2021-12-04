using System;
using System.Collections.Generic;
using System.Text;

namespace FatalFlashcards
{
    [Serializable]
    public class Flashcard
    {
        Random rnd = new Random();

        private string _Question;
        private string _CorrectAnswer;
        private string _WrongAnswer1;
        private string _WrongAnswer2;
        private string _WrongAnswer3;

        private List<string> _AllAnswers;

        public Flashcard(string line)
        {
            _AllAnswers = new List<string>();

            string[] cols = line.Split("|");

            this._Question = cols[0];
            this._CorrectAnswer = cols[1];
            this._WrongAnswer1 = cols[2];
            this._WrongAnswer2 = cols[3];
            this._WrongAnswer3 = cols[4];

            _AllAnswers.Add(_CorrectAnswer);
            _AllAnswers.Add(_WrongAnswer1);
            _AllAnswers.Add(_WrongAnswer2);
            _AllAnswers.Add(_WrongAnswer3);
        }

        public void Shuffle()
        {
            for(int i=0; i<100; i++)
            {
                int position1 = rnd.Next(_AllAnswers.Count);
                int position2 = rnd.Next(_AllAnswers.Count);

                //hold one answer in memory
                string answer = _AllAnswers[position1];
                //swap the second answer to the first position
                _AllAnswers[position1] = _AllAnswers[position2];
                //add the stored answer to the second position
                _AllAnswers[position2] = answer;
            }
        }
    }
}
