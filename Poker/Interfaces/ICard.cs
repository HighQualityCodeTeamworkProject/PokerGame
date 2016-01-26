using Poker.Enums;

namespace Poker.Interfaces
{
    public interface ICard
    {
        RankVariations Rank { get; set; }
        SuitVariations CardType { get; set; }
    }
}
