using System;
using System.Collections.Generic;

namespace Poker
{
    public class Menu
    {

        private Repartidora repartidora = new Repartidora();
        private Probability probability = new Probability();

        public void Start(Mazo mazo)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nBienvenido al programa que calcula las probabilidades del Poker!!\n 1- Escriba 'Aleatorio' si deseas que te repartamos tus 2 cartas aleatoreamente.\n 2- Escriba 'Manual' para elegir tus 2 cartas de forma manual.");
            string response = Console.ReadLine();


            if (response.Trim() == "aleatorio")
            {
                repartidora.RepartirMisCartas(mazo);
                repartidora.RepartirCartasEnMesa(mazo);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nTus cartas son .");
                Printer.Print(repartidora.MisCartas);
                Console.ForegroundColor = ConsoleColor.White;
                // Console.WriteLine($"Las cartas que salieron en la mesa son. ");
                // Printer.Print(repartidora.CartasEnMesa);
            }
            else if (response.Trim() == "manual")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("¿Qué cartas desea elegir?\n Escriba las cartas con el formato '6-corazones y A-diamantes'.\nLos palos disponibles son: 'Corazones', 'Diamantes', 'Picas' y 'Trebol'");
                Console.ForegroundColor = ConsoleColor.White;
                string newResponse = Console.ReadLine();
                
                string[] splitCards = newResponse.ToLower().Split("y");

                foreach (var card in splitCards)
                {
                    string[] valueAndPalo = card.Split("-");
                    transformStringToPalo(valueAndPalo[0], valueAndPalo[1], mazo);
                }
                Console.WriteLine($"\nTus cartas son .");
                Printer.Print(repartidora.MisCartas);

                // Console.WriteLine($"\nLas cartas que salieron en la mesa son. ");
                // repartidora.RepartirCartasEnMesa(mazo);
                //Printer.Print(repartidora.CartasEnMesa);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                throw new WrongResponseException("Escribiste una opción incorrecta o lo hiciste de manera incorrecta. Intente de nuevo.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine($"\nDe que jugada quieres calcular la probabilidad? ");
            Console.WriteLine("\t-Pulsa '1' para calcular la probabilidad de obtener Color. \n\t-Pulsa '2' para calcular la probabilidad de obtener Escalera Real. \n\t-Pulsa '3' para calcular la probabilidad de obtener Full House.");
            string responseProbability = Console.ReadLine();


            switch (responseProbability)
            {
                case "1":
                    Console.WriteLine($"La probabilidad de obtener un Color con tus cartas ({repartidora.MisCartas[0].Descripcion}, {repartidora.MisCartas[1].Descripcion})  es de {probability.probabilityOfColor(repartidora)}%");
                    break;
                case "2":
                    Console.WriteLine($"La probabilidad de obtener una Escalera Real con tus cartas ({repartidora.MisCartas[0].Descripcion}, {repartidora.MisCartas[1].Descripcion})  es de {probability.probabilityOfEscaleraReal(repartidora)}%");
                    break;
                case "3":
                    Console.WriteLine($"La probabilidad de obtener un Full House con tus cartas ({repartidora.MisCartas[0].Descripcion}, {repartidora.MisCartas[1].Descripcion})  es de {probability.probabilityOfFullHouse(repartidora)}%");
                    break;
                default:
                    break;
            }
        }
        private void transformStringToPalo(string value, string paloString, Mazo mazo)
        {
            if (paloString.Trim().Equals("diamantes"))
            {
                IPalo diamantes = new Diamantes(value.Trim());
                repartidora.MisCartas.Add(diamantes.AloneCarta);
                mazo.MazoCartas.Remove(diamantes.AloneCarta);

            }
            else if (paloString.Trim().Equals("corazones"))
            {
                IPalo corazones = new Corazones(value.Trim());
                repartidora.MisCartas.Add(corazones.AloneCarta);
                mazo.MazoCartas.Remove(corazones.AloneCarta);
            }
            else if (paloString.Trim().Equals("picas"))
            {
                IPalo picas = new Picas(value.Trim());
                repartidora.MisCartas.Add(picas.AloneCarta);
                mazo.MazoCartas.Remove(picas.AloneCarta);
            }
            else if (paloString.Trim().Equals("trebol"))
            {
                IPalo trebol = new Trebol(value.Trim());
                repartidora.MisCartas.Add(trebol.AloneCarta);
                mazo.MazoCartas.Remove(trebol.AloneCarta);
            }
            else
            {
                throw new WrongResponseException("Escribiste mal el formato de la carta.");
            }
        }
    }
}

