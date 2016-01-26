using System.Collections.Generic;

namespace Poker.Interfaces
{
    public interface IPokerDatabase
    {
        IList<ICard> Deck { get; set; }
        IList<ICharacter> HumanPlayers { get; set; }
        IList<ICharacter> BotPlayers { get; set; }
        IList<ICard> TableCards { get; set; }

        void AddBot(ICharacter bot);
        void AddHuman(ICharacter human);
        void AddCard(ICard card);
    }
}
