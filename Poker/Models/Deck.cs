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

        //Fisher-Yates Shuffle Algorithm
        public void Shuffle()
        {
            var randomNumberGenerator = new Random();

            var shuffledDeck = this.cards.ToArray();
            for (var currentCardIndex = 0; currentCardIndex < Constants.NumberOfCardsInDeck; currentCardIndex++)
            {
                int nextPositionInDeck = currentCardIndex + randomNumberGenerator.Next(0, Constants.NumberOfCardsInDeck - currentCardIndex);
                var movedCard = shuffledDeck[currentCardIndex];
                shuffledDeck[currentCardIndex] = shuffledDeck[nextPositionInDeck];
                shuffledDeck[nextPositionInDeck] = movedCard;
            }
            this.Cards = shuffledDeck;
        }

    }
}
