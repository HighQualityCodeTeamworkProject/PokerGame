namespace Poker.Interfaces
{
    public interface ITableManager
    {
        int ChipsOnTable { get; set; }

        int CardsOnTable { get; set; }
    }
}
