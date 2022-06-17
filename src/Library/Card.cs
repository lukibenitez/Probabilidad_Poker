using System;
using System.Collections.Generic;

namespace Poker
{
    public class Card
    {
        public string Value { get; set; }
        public Suit Suit { get; set; }
        public short Rank { get; set; }

        public Card(string value, Suit suit, short rank)
        {
            Value = value;
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return String.Format($"{Value} {Suit}");
        }

        public static bool operator <(Card a, Card b)
        {
            return a.Rank < b.Rank;
        }

        public static bool operator >(Card a, Card b)
        {
            return a.Rank > b.Rank;
        }

        public static bool operator ==(Card a, Card b)
        {
            return a.Rank == b.Rank;
        }

                public static bool operator !=(Card a, Card b)
        {
            return a.Rank != b.Rank;
        }
    }
}