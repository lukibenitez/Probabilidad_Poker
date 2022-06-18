using System;
using System.Collections.Generic;

namespace Poker
{
    public class Mazo 
    {
        private List<Carta> mazo = new List<Carta>(); 
        public List<Carta> MazoCartas { get{return this.mazo; } }
        public Mazo() 
        {
            Corazones corazones = new Corazones();
            Diamante diamante = new Diamante();
            Picas picas = new Picas();
            Trebol trebol = new Trebol();

            foreach (var carta in corazones.Cartas)
            {
                mazo.Add(carta);
            }
            foreach (var carta in diamante.Cartas)
            {
                mazo.Add(carta);
            }
            foreach (var carta in picas.Cartas)
            {
                mazo.Add(carta);
            }
            foreach (var carta in trebol.Cartas)
            {
                mazo.Add(carta);
            }
        }

        
    }
}