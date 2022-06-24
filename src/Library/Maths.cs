using System;
using System.Collections;

namespace Poker
{
    public static class Maths
    {
        private static List<int> numbers = new List<int>();
        public static double Factorial(double n)
        {
            if ((n==0)|| (n==1))
            {
                return 1;
            }
            else
            {
                return n * Factorial(n-1);
            }
        }
        

        public static double Combinaciones(double n, double p)
        {
            return Factorial(n) / (Factorial(p) * Factorial(n - p));
        }
    }
}