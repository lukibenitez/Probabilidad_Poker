using System;
using System.Collections.Generic;

namespace Poker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mazo mazo = new Mazo();
            
            //Console.WriteLine(mazo.MazoCartas.Count);

            // foreach (var carta in mazo.MazoCartas)
            // {
            //     Console.WriteLine($"Soy la carta {carta.Valor} de {carta.Palo.Nombre}");
            // }
            Repartidora repartidora = new Repartidora();
            repartidora.Repartir(mazo);
            Console.WriteLine("\nLas cartas que me tocaron son: ");
            foreach (var miscartas in repartidora.MisCartas)
            {
                Console.WriteLine(miscartas.Descripcion);
            }
            Console.WriteLine("\n Las cartas en la mesa son: ");
            foreach (var cartasMesa in repartidora.CartasEnMesa)
            {
                Console.WriteLine(cartasMesa.Descripcion);
            }
            
           // Console.WriteLine(repartidora.CartasEnMesa);
        }
    }
}