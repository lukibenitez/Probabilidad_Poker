namespace Poker
{
    public class Probability
    {
        private double inicialProbability = 0;
        private double mediumProbability = 0;
        private double finalProbability = 0;
        private List<string> numerosReales = new List<string> ();
        
        public double probabilityOfColor(Repartidora repartidora)
        {
            double inicialProbability = 2 * (Maths.Combinaciones(26, 5) / Maths.Combinaciones(50, 5)); // 0,062 /// 6,2 %
            if (repartidora.MisCartas[0].Palo.Nombre != repartidora.MisCartas[1].Palo.Nombre) // mis dos cartas son de distintos palos
            {
                mediumProbability = ((Maths.Combinaciones(12, 4) * 38) / (Maths.Combinaciones(50, 5))) + (Maths.Combinaciones(12, 5) / Maths.Combinaciones(50, 5));
                mediumProbability = mediumProbability * 2; // probabilidad de que el color sea de una o otra de mis dos cartas
            }
            if (repartidora.MisCartas[0].Palo.Nombre == repartidora.MisCartas[1].Palo.Nombre) //mis dos cartas son del mismo palo
            {
                mediumProbability = ((Maths.Combinaciones(12, 3) * 39 * 38) / (Maths.Combinaciones(50, 5))) + ((Maths.Combinaciones(12, 4) * 39) / (Maths.Combinaciones(50, 5))) + ((Maths.Combinaciones(12, 5)) / (Maths.Combinaciones(50, 5)));
            }
            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }

        public double probabilityOfFullHouse(Repartidora repartidora)
        {
            double inicialProbability = (11 * Maths.Combinaciones(4, 3) * Maths.Combinaciones(4, 2) ) / (Maths.Combinaciones(50, 5));
            if (repartidora.MisCartas[0].Valor != repartidora.MisCartas[1].Valor) // mis dos cartas son de distintos palos
            {
                mediumProbability =  ( (2) * ((Maths.Combinaciones(3,2) * Maths.Combinaciones(3, 1) * Maths.Combinaciones(44, 2))/(Maths.Combinaciones(50, 2))) ) +  ((Maths.Combinaciones(3,2) * Maths.Combinaciones(3,2) * Maths.Combinaciones(4,1))/(Maths.Combinaciones(50,2)));
                //2. (3𝐶2 . 3𝐶1 . 44𝐶2 / 50C2) + (3𝐶2  . 3𝐶2  . 44𝐶1 / 50𝐶2) 
            }
          
            if (repartidora.MisCartas[0].Valor == repartidora.MisCartas[1].Valor) //mis dos cartas son del mismo palo
            {
                
            }
            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }

        public double probabilityOfEscaleraReal(Repartidora repartidora)
        {
            numerosReales.Add("10");
            numerosReales.Add("J");
            numerosReales.Add("Q");
            numerosReales.Add("K");
            numerosReales.Add("A");
            inicialProbability = Maths.Combinaciones(50, 5);
            if (repartidora.MisCartas[0].Palo.Nombre == repartidora.MisCartas[1].Palo.Nombre &&  numerosReales.Contains(repartidora.MisCartas[0].Valor) && numerosReales.Contains(repartidora.MisCartas[1].Valor) ) // mis cartas son del mismo palo y son valores reales
            {
                mediumProbability = (4) / (Maths.Combinaciones(50, 3));
            }
            // y si mis cartas son de difente palo y no son valores reales,
            // serian la inicial.
            
               
            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }
    }
}
