using Poker.Enums;
using Poker.Interfaces;
using Poker.Models;

namespace Poker.Core
{
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(RankVariations rank, SuitVariations cardType)
        {
            var card = new Card(rank, cardType);

            return card;
        }
        
    }
}
