﻿using System;

namespace DeckOfCards
{
    public interface ICard
    {
        string Code { get; }
        Guid FromDeckId { get; set; }
        ICardSet AssignedTo { get; set; }
        int StackOrder { get; set; }
        string Description { get; }
    }
}