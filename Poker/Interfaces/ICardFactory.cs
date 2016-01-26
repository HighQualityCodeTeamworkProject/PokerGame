using Poker.Enums;

namespace Poker.Interfaces
{
    public interface ICardFactory
    {
        ICard CreateCard(RankVariations rank, SuitVariations cardType);
    }
}
