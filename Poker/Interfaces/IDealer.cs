using System.Collections.Generic;
using Poker.Models;

namespace Poker.Interfaces
{
    public interface IDealer
    {
        void SetWinner();

        void CheckHandPower();

        void DealCards(IList<ICard> deck, IList<ICharacter> humans, IList<ICharacter> bots, IList<ICard> tableCards);

        void Shuffle(IList<ICard> deck);

        void FillDeck(IPokerDatabase database, ICardFactory cardFactory);
    }
}
