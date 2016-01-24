using System;
using System.Windows.Forms;
using Poker.Models;

namespace Poker
{
    public partial class GameEngine : Form
    {
        private Deck deck;

        public GameEngine()
        {
            InitializeComponent();
        }

        private void GameEngine_Load(object sender, EventArgs e)
        {
            this.deck = DeckLoader.Instance.Load();
        }
    }
}
