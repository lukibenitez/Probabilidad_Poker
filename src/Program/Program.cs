using System;
using System.Collections.Generic;

namespace Poker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            Menu menu = new Menu();
            //menu.Start(mazo);
            bool keepAsking;
            do
            {
                keepAsking = false;

                try
                {
                    menu.Start(mazo);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("\nEscribiste una opción incorrecta o lo hiciste de manera incorrecta. Intente de nuevo.");
                    keepAsking = true;
                }
            }
            while (keepAsking);

            // Console.WriteLine("Hello tell me an option");
            // string options = Console.ReadLine();

            // Console.WriteLine("Now, tel me a card");

            // string card = Console.ReadLine();

            // Console.WriteLine($"You have said: option {options}, card {card}");

            // Console.ReadKey();





        }
    }
}