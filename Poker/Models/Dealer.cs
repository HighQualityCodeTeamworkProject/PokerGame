using System;
using System.Linq;
using Poker.Interfaces;

namespace Poker.Models
{
    public class Dealer : IDealer
    {
        Card[] cards = new Card[Constants.NumberOfCardsInDeck];

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

        public Card[] Cards { get; set; }

        public Card DealCards()
        {
            throw new NotImplementedException();
        }
    }
}
