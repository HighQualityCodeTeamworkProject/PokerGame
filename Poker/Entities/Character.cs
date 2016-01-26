using System.Collections.Generic;
using Poker.Interfaces;

namespace Poker.Entities
{
    public abstract class Character : ICharacter
    {
        public string Name { get; set; }
        public int Chips { get; set; }
        public IList<ICard> Hand { get; set; }
        public int Power { get; set; }


        protected Character(string name, int chips, int power = 0)
        {
            this.Name = name;
            this.Hand = new List<ICard>();
            this.Power = power;
            this.Chips = chips;
        }

        public void AllIn()
        {
            throw new System.NotImplementedException();
        }

        public void Check()
        {
            throw new System.NotImplementedException();
        }

        public void Raise()
        {
            throw new System.NotImplementedException();
        }

        public void Fold()
        {
            throw new System.NotImplementedException();
        }

        public void Call()
        {
            throw new System.NotImplementedException();
        }
    }
}
