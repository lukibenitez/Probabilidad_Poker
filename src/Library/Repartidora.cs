using System;
using System.Collections.Generic;

namespace Poker
{
    public class Repartidora
    {
        private List<Carta> misCartas = new List<Carta>();
        private List<Carta> cartasEnMesa = new List<Carta>();
        private List<int> numerosAleatorios = new List<int>();

        public List<Carta> MisCartas { get { return this.misCartas; } }
        public List<Carta> CartasEnMesa { get { return this.cartasEnMesa; } }
        public void Repartir(Mazo mazo)
        {
            Random random = new Random();
            for (int i = 1; i < 3; i++)
            {
                int randomCarta = random.Next(0, 51);
                while (numerosAleatorios.Contains(randomCarta))
                {
                    randomCarta = random.Next(0, 51);
                }
                numerosAleatorios.Add(randomCarta);
                misCartas.Add(mazo.MazoCartas[randomCarta]);
                mazo.MazoCartas.RemoveAt(randomCarta);

            }

            for (int i = 1; i < 6; i++)
            {

                int randomCarta = random.Next(0, 51);
                while (numerosAleatorios.Contains(randomCarta))
                {
                    randomCarta = random.Next(0, 51);
                }
                numerosAleatorios.Add(randomCarta);
                cartasEnMesa.Add(mazo.MazoCartas[randomCarta]);
                mazo.MazoCartas.RemoveAt(randomCarta);
            }
        }
    }
}