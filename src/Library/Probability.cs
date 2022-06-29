namespace Poker
{
    public class Probability
    {
        private double inicialProbability = 0;
        private double mediumProbability = 0;
        private double finalProbability = 0;
        private List<string> numerosReales = new List<string>()
        {
            "10", "J", "Q", "K", "A", "j", "q", "k", "a"
        };

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

        public double probabilityOfEscaleraReal(Repartidora repartidora) // esta bien
        {
            // -----------3 CHANCES-------------
            //1. Que salga escalera real en la mesa.
            //2. Que salga escalera real con una de mis cartas.
            //3. Que salga escalera real con mis dos cartas. 
            
            if ( !((numerosReales.Contains(repartidora.MisCartas[0].Valor)) &&  (numerosReales.Contains(repartidora.MisCartas[1].Valor))) )
            {
                //2-picas y 3-picas
                inicialProbability = (4) / (Maths.Combinaciones(50, 5)); //bien, tenemos lo mismo con franco.
            }
            
            if (repartidora.MisCartas[0].Palo.Nombre == repartidora.MisCartas[1].Palo.Nombre && numerosReales.Contains(repartidora.MisCartas[0].Valor) && numerosReales.Contains(repartidora.MisCartas[1].Valor) &&(repartidora.MisCartas[0].Valor != repartidora.MisCartas[1].Valor)) // mis cartas son del mismo palo y son valores reales distintos 
            {
                //A-corazones y K-corazones
                inicialProbability = (3) / (Maths.Combinaciones(50, 5));
                mediumProbability = (Maths.Combinaciones(47, 2)) / (Maths.Combinaciones(50, 5));
            }

            if ( (numerosReales.Contains(repartidora.MisCartas[0].Valor) && ! numerosReales.Contains(repartidora.MisCartas[1].Valor)) || ( numerosReales.Contains(repartidora.MisCartas[1].Valor)&& ! numerosReales.Contains(repartidora.MisCartas[0].Valor))) // mis cartas son del mismo palo y son valores reales)
            {
                //Q-picas y 3-picas
                inicialProbability = (3) / (Maths.Combinaciones(50, 5));
                mediumProbability = (46) / (Maths.Combinaciones(50, 5)); //primer audio min 3:00
            }
            if (  (repartidora.MisCartas[0].Palo.Nombre != repartidora.MisCartas[1].Palo.Nombre) && (numerosReales.Contains(repartidora.MisCartas[0].Valor) && numerosReales.Contains(repartidora.MisCartas[1].Valor)) ) 
            {
                //Q trebol y K corazones
                inicialProbability = (2) / (Maths.Combinaciones(50, 5));
                mediumProbability =   ((2)* (46) ) / (Maths.Combinaciones(50, 5));
            }

            finalProbability = (inicialProbability + mediumProbability) * 100;
            return finalProbability;
        }

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
    }
}
