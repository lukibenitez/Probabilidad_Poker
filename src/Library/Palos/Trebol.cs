using System;
using System.Collections.Generic;

namespace Poker
{
    public class Trebol : IPalo
    {
        private string nombre = "Trebol";
        public string Nombre { get { return this.nombre; } }
        private List<Carta> cartas = new List<Carta>();

        public List<Carta> Cartas { get { return this.cartas; } }
        private Carta aloneCarta;
        public Trebol(string value)
        {
            this.aloneCarta = new Carta(value, this);
        }
        public Carta AloneCarta { get { return this.aloneCarta;} }

        public Trebol()
        {
            for (int i = 2; i < 11; i++)
            {
                Carta cartasTreboles = new Carta(i.ToString(), this);
                cartas.Add(cartasTreboles);
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