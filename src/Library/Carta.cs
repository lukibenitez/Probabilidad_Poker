using System;
using System.Collections.Generic;

namespace Poker
{
    public class Carta
    {
        private IPalo palo;
        private string valor;
        private string descripcion = "";
        public string Descripcion {get{return $"{this.valor} de {this.palo.Nombre}";}}

        public IPalo Palo {get{return this.palo;}}
        public string Valor {get{return this.valor;}}
        public Carta(string valor, IPalo palo)
        {
            this.palo = palo;
            this.valor = valor;
        }
    }
}