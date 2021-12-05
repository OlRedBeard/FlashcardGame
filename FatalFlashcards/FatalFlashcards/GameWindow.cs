using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FatalFlashcards
{
    public partial class GameWindow : Form
    {
        FlashcardSet deck;
        GameSettings gs;
        GameMenuLarge previousForm;

        public GameWindow(GameSettings settings, GameMenuLarge menu, FlashcardSet set)
        {
            InitializeComponent();
            deck = set;
            gs = settings;
            previousForm = menu;

            foreach (Flashcard card in deck._flashcards)
            {
                card.Shuffle();
            }

            deck.ShuffleCards(deck._flashcards);

            picLife.Visible = false;
            lblPoints.Visible = false;
            lblQuestion.Text = "Would you like a brief tutorial?";
            lblOptionA.Text = "Yes";
            lblOptionB.Text = "No";

        }
    }
}
