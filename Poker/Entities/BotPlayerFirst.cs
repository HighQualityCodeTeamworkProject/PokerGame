﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Entities
{
    using Poker.Interfaces;

    public class BotPlayerFirst : ICharacter
    {
        public long Chips { get; set; }
    }
}
