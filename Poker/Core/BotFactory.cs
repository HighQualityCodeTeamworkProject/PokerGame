using Poker.Entities;
using Poker.Interfaces;

namespace Poker.Core
{
    public class BotFactory : IBotFactory
    {
        public ICharacter CreateBot(string name, int chips, int power = 0)
        {
            ICharacter bot = new Bot(name, chips, power);

            return bot;
        }
    }
}
