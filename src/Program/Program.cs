using System;
using System.Collections.Generic;

namespace Poker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            //Console.WriteLine(deck.Deal());
            //Console.WriteLine(deck.DealHand());

            //Console.WriteLine(deck.DealHand());

            Console.WriteLine("Jugador 1");
            Console.WriteLine(deck.Deal());

            Hand jugador1 = deck.DealHand();
            Console.WriteLine();
            jugador1.Print();
            Console.WriteLine();

            deck.color();
            deck.color();

/*
            Console.WriteLine("Jugador 2");
            Hand jugador2 = deck.DealHand();
            jugador2.Print();

            if (jugador1 > jugador2)
            {
                Console.WriteLine("Gano Jugador 1");
            }
            */

            //Console.ReadKey();

        }
/*
        public void color()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                if (cards )
                {

                }

            }
        }
*/

    }
}