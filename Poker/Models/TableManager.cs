using System;
using System.Linq;
using Poker.Interfaces;

namespace Poker.Models
{
    public class TableManager : ITableManager
    {
        public int ChipsOnTable { get; set; }

        public int CardsOnTable { get; set; }
    }
}
