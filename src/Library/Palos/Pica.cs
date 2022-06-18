using System;
using System.Collections.Generic;

namespace Poker
{
    public class Picas : IPalo
    {
        private string nombre = "picas";
        public string Nombre { get{return this.nombre; } }
        private List<Carta> cartas = new List<Carta>();

        public List<Carta> Cartas { get{return this.cartas; } }

        public Picas()
        {
            for (int i = 2; i < 11; i++)
            {
                Carta cartasPicas = new Carta(this, i.ToString());
                cartas.Add(cartasPicas);
            }
            Carta j = new Carta(this, "J");
            cartas.Add(j);
            Carta q = new Carta(this, "Q");
            cartas.Add(q);
            Carta k = new Carta(this, "K");
            cartas.Add(k);
            Carta aS = new Carta(this, "AS");
            cartas.Add(aS);
        }
    }
}