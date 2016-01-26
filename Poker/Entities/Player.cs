using System.Collections.Generic;
using Poker.Interfaces;
using Poker.Models;

namespace Poker.Entities
{
    public class Player : Character
    {
        public Player(string name, int chips, int power = 0) :base(name, chips, power)
        {
            this.Name = name;
            this.Hand = new List<ICard>();
            this.Power = power;
            this.Chips = chips;
        }
    }
}
