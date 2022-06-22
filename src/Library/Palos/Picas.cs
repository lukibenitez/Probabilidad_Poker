using System;
using System.Collections.Generic;

namespace Poker
{
    public class Picas : IPalo
    {
        private string nombre = "picas";
        public string Nombre { get { return this.nombre; } }
        private List<Carta> cartas = new List<Carta>();

        public List<Carta> Cartas { get { return this.cartas; } }
        private Carta aloneCarta;
        public Picas(string value)
        {
            this.aloneCarta = new Carta(value, this);
        }
        public Carta AloneCarta { get { return this.aloneCarta;} }

        public Picas()
        {
            for (int i = 2; i < 11; i++)
            {
                Carta cartasPicas = new Carta(i.ToString(), this);
                cartas.Add(cartasPicas);
            }
            Carta j = new Carta("J", this);
            cartas.Add(j);
            Carta q = new Carta("Q", this);
            cartas.Add(q);
            Carta k = new Carta("K", this);
            cartas.Add(k);
            Carta aS = new Carta("A", this);
            cartas.Add(aS);
        }
    }
}