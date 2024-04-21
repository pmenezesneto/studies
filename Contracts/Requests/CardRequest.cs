﻿using Contracts.Cards;

namespace Contracts.Requests
{
    public class CardRequest
    {
        public CardType CardType { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;
    }
}
