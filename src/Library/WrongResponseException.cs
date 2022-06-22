using System;
using System.Runtime.Serialization;

namespace Poker
{
    public class WrongResponseException : Exception
    {
        public WrongResponseException(string message)
        {
            //message = "Escribiste una opción incorrecta o lo hiciste de manera incorrecta. Intente de nuevo."; 
        }
    }

}


