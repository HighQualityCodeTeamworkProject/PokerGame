using System.Collections.Generic;
using Poker.Interfaces;

namespace Poker.Entities
{
    class Bot : Character, IControlledAI
    {
        public Bot(string name, int chips, int power = 0)
            : base(name, chips, power)
        {
            this.Hand = new List<ICard>();
        }


        public void Decision()
        {

        }
    }
}
