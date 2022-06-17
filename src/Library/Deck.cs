using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand
    {
        private List<Card> cards;
        
        public Hand(List<Card> cards)
        {
            this.cards = cards;
        }

        public void Print()
        {
            foreach (var c in cards)
            {
                Console.WriteLine(c);
            }
        }

        public static bool operator > (Hand a, Hand b)
        {
            return true;
        }

        public static bool operator < (Hand a, Hand b)
        {
            return true;
        }
    }
    public class Deck
    {
        public float count = 0.0f;
        public string Theme { get; set; }
        private List<Card> cards = new List<Card>();
        private short puntero = 0;


        public Deck()
        {
            Theme = "Default Theme";

            for (int s = 0; s < 4; s++)
            {
                cards.Add(new Card("2", (Suit) s, 2));
                cards.Add(new Card("3", (Suit) s, 3));
                cards.Add(new Card("4", (Suit) s, 4));
                cards.Add(new Card("5", (Suit) s, 5));
                cards.Add(new Card("6", (Suit) s, 6));
                cards.Add(new Card("7", (Suit) s, 7));
                cards.Add(new Card("8", (Suit) s, 8));
                cards.Add(new Card("9", (Suit) s, 9));
                cards.Add(new Card("10", (Suit) s, 10));
                cards.Add(new Card("J", (Suit) s, 11));
                cards.Add(new Card("Q", (Suit) s, 12));
                cards.Add(new Card("K", (Suit) s, 13));
                cards.Add(new Card("A", (Suit) s, 14));
            }
        }
        public void PrintCards()
        {
            foreach (var c in cards)
            {
                Console.WriteLine(c);
            }
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int pos = random.Next(0, 51);
                Card other = cards[pos];
                cards[pos] = cards[i];
                cards[i] = other;
            }
        }

        public Card Deal()
        {
            if (puntero >= cards.Count)
            {
                throw new Exception("No hay cartas");
            }

            Card carta = cards[puntero++];
            return carta;
        }

        public Hand DealHand()
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 2; i++)
            {
                cards.Add(this.Deal());
                cards.Remove(this.Deal());
            }
            return new Hand(cards);
        }

        public void color()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(this.Deal());
            }
        }

        public void Probability()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                count ++;
            }

            Console.WriteLine(count);
            float probability = (((100f) / count) * 3);
            Console.WriteLine(probability);
        }
    }
}

