using Poker.Models;

namespace Poker.Interfaces
{
    public interface IDealer
    {
        Card[] Cards { get; set; }

        Card DealCards();

        void Shuffle();
    }
}
