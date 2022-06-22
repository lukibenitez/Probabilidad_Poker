using System;
using System.Collections.Generic;

namespace Poker
{
    public class Menu
    {
        private bool randomOrNot = false;
        private Repartidora repartidora = new Repartidora();
        //private bool correctResponse = false;
        public void Start(Mazo mazo)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nBienvenido al programa que calcula las probabilidades del Poker!!\n 1- Pulsa '1' para que te repartamos tus 2 cartas aleatoreamente.\n 2- Pulsa '2' para elegir tus 2 cartas.");
            int response = Convert.ToInt16(Console.ReadLine());
            //int response = 1;
            switch (response)
            {
                case 1: //anda bien
                    repartidora.RepartirMisCartas(mazo);
                    repartidora.RepartirCartasEnMesa(mazo);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nTus cartas son .");
                    Printer.Print(repartidora.MisCartas);
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine($"\nLas cartas que salieron en la mesa son. ");
                    Printer.Print(repartidora.CartasEnMesa);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("¿Qué cartas desea elegir?\n Escriba las cartas con el formato '6-corazones y A-diamantes'.\nLos palos disponibles son: 'Corazones', 'Diamantes', 'Picas' y 'Trebol'");
                    Console.ForegroundColor = ConsoleColor.White;
                    string newResponse = Console.ReadLine().ToString();
                    //string newResponse = "6-corazones y A-diamantes";
                    string[] splitCards = newResponse.Split("y");
                   
                    foreach (var card in splitCards)
                    {
                        string[] valueAndPalo = card.Split("-");
                        transformStringToPalo(valueAndPalo[0], valueAndPalo[1]);
                    }
                    Console.WriteLine($"\nTus cartas son .");
                    Printer.Print(repartidora.MisCartas);
                    
                    Console.WriteLine($"\nLas cartas que salieron en la mesa son. ");
                    repartidora.RepartirCartasEnMesa(mazo);
                    Printer.Print(repartidora.CartasEnMesa);

                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    throw new WrongResponseException("Escribiste una opción incorrecta o lo hiciste de manera incorrecta. Intente de nuevo.");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine("No se preogramar");
                    break;
            }
        }

        private void transformStringToPalo(string value, string paloString)
        {
            if (paloString.Trim().Equals("diamantes"))
            {
                IPalo diamantes = new Diamantes(value.Trim());
                repartidora.MisCartas.Add(diamantes.AloneCarta);
            }
            else if (paloString.Trim().Equals("corazones"))
            {
                IPalo corazones = new Corazones(value.Trim());
                repartidora.MisCartas.Add(corazones.AloneCarta);
            }
            else if (paloString.Trim().Equals("picas"))
            {
                IPalo picas = new Picas(value.Trim());
                repartidora.MisCartas.Add(picas.AloneCarta);
            }
            else if (paloString.Trim().Equals("trebol"))
            {
                IPalo trebol = new Trebol(value.Trim());
                repartidora.MisCartas.Add(trebol.AloneCarta);
            }
            else
            {
                throw new WrongResponseException("Escribiste mal el formato de la carta.");
            }
        }

        //private void nextResponse()
        // {
        //     Console.WriteLine("¿Qué cartas desea elegir?\n Escriba las cartas con el formato '6-corazones y AS-diamantes'.\nLos palos disponibles son: 'Corazones', 'Diamantes', 'Picas' y 'Trebol'");
        //     string response = Console.ReadLine();
        //     response1.Trim();
        //     string[] splitCards = response1.Split("y");

        //     foreach (var card in splitCards)
        //     {
        //         string[] valueAndPalo = card.Split("-");
        //         transformStringToPalo(valueAndPalo[0], valueAndPalo[1]);
        //         transformStringToPalo(valueAndPalo[2], valueAndPalo[3]);
        //     }
        //     Console.WriteLine($"\nTus cartas son .");
        //     Printer.Print(repartidora.MisCartas);
        //     Console.WriteLine($"\nLas cartas que salieron en la mesa son. ");
        //     Printer.Print(repartidora.CartasEnMesa);
        // }

        public bool RandomOrNot { get { return this.randomOrNot; } }
    }
}

