using Poker.Enums;
using Poker.Interfaces;

namespace Poker.Models
{
    public class Card : ICard
    {
        public Card(RankVariations rank, SuitVariations cardType)
        {
            this.Rank = rank;
            this.CardType = cardType;
        }

        public RankVariations Rank { get; set; }
        public SuitVariations CardType { get; set; }
    }
}
