using System;
using System.Linq;

namespace Poker.Models
{
    public class Deck
    {
        private Card[] cards = new Card[Constants.NumberOfCardsInDeck];

        public Card[] Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }
    }
}
