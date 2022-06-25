namespace Poker
{
    public class Probability
    {
        private double inicialProbability = 0;
        private double mediumProbability = 0;
        private double finalProbability = 0;
        private List<string> numerosReales = new List<string>();

        public double probabilityOfColor(Repartidora repartidora)
        {
            double inicialProbability = 2 * (Maths.Combinaciones(26, 5) / Maths.Combinaciones(50, 5)); // 0,062 /// 6,2 %    // ESTA PERFECTO
            if (repartidora.MisCartas[0].Palo.Nombre != repartidora.MisCartas[1].Palo.Nombre) // mis dos cartas son de distintos palos
            {
                mediumProbability = ((Maths.Combinaciones(12, 4) * 38) / (Maths.Combinaciones(50, 5))) + (Maths.Combinaciones(12, 5) / Maths.Combinaciones(50, 5));
                mediumProbability = mediumProbability * 2; // probabilidad de que el color sea de una o otra de mis dos cartas
            }
            if (repartidora.MisCartas[0].Palo.Nombre == repartidora.MisCartas[1].Palo.Nombre) //mis dos cartas son del mismo palo
            {
                mediumProbability = ((Maths.Combinaciones(11, 3) * Maths.Combinaciones(39, 2)) / (Maths.Combinaciones(50, 5))) + ((Maths.Combinaciones(11, 4) * 39) / (Maths.Combinaciones(50, 5))) + ((Maths.Combinaciones(11, 5)) / (Maths.Combinaciones(50, 5))); //ESTE ESTA PERFECTO
            }
            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }

        // public double probabilityOfPoker(Repartidora repartidora)
        // {

        // }

        public double probabilityOfFullHouse(Repartidora repartidora)
        {
            double inicialProbability = (11 * Maths.Combinaciones(4, 3) * Maths.Combinaciones(4, 2)) / (Maths.Combinaciones(50, 5)); // esta biem 
            if (repartidora.MisCartas[0].Valor != repartidora.MisCartas[1].Valor) // mis dos cartas son de distintos palos
            {
                mediumProbability = ((2) * ((Maths.Combinaciones(3, 2) * Maths.Combinaciones(3, 1) * Maths.Combinaciones(47, 2)) / (Maths.Combinaciones(50, 5)))); // divino
                //2. (3𝐶2 . 3𝐶1 . 44𝐶2 / 50C2) + (3𝐶2  . 3𝐶2  . 44𝐶1 / 50𝐶2) 
            }

            if (repartidora.MisCartas[0].Valor == repartidora.MisCartas[1].Valor) //mis dos cartas son del mismo palo
            {

                mediumProbability = (((Maths.Combinaciones(2, 1) * (Maths.Combinaciones(12, 2) * 4) * (Maths.Combinaciones(47, 2))) / (Maths.Combinaciones(50, 5)))); // divino



                mediumProbability += (((Maths.Combinaciones(12, 3) * (Maths.Combinaciones(47, 2))) / (Maths.Combinaciones(50, 5)))); // divino
            }
            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }

        public double probabilityOfEscaleraReal(Repartidora repartidora) // esta bien
        {
            numerosReales.Add("10");
            numerosReales.Add("J");
            numerosReales.Add("Q");
            numerosReales.Add("K");
            numerosReales.Add("A");
            inicialProbability = (4) / (Maths.Combinaciones(50, 2));
            if (repartidora.MisCartas[0].Palo.Nombre == repartidora.MisCartas[1].Palo.Nombre && numerosReales.Contains(repartidora.MisCartas[0].Valor) && numerosReales.Contains(repartidora.MisCartas[1].Valor)) // mis cartas son del mismo palo y son valores reales
            {
                mediumProbability = (Maths.Combinaciones(47, 2)) / (Maths.Combinaciones(50, 5));
            }

            if (numerosReales.Contains(repartidora.MisCartas[0].Valor) || numerosReales.Contains(repartidora.MisCartas[1].Valor)) // mis cartas son del mismo palo y son valores reales)
            {
                mediumProbability = (46) / (Maths.Combinaciones(50, 5));
            }
            // y si mis cartas son de difente palo y no son valores reales,
            // serian la inicial.


            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }
    }
}
