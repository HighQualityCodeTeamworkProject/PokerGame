using System.Collections.Generic;
using Poker.Models;

namespace Poker.Interfaces
{
    public interface ICharacter 
    {
        string Name { get; set; }
        int Chips { get; set; }
        IList<ICard> Hand { get; set; }
        int Power { get; set; }

        void AllIn();

        void Check();

        void Raise();

        void Fold();

        void Call();
    }
}