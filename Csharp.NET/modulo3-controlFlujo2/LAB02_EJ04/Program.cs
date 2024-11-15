using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Mostrar la conversion de 1 hasta 10 euros en pesos, euro tras euro 
            suponiendo que el tipo de cambio es es 1350 pesos por euro
             */

            // declaro las variables
            float euro = 1;
            const float CAMBIO = 1350f;

            while (euro <= 10)
            {
                float pesos = euro * CAMBIO;
                Console.WriteLine($"{euro} euros = {pesos} pesos");
                euro++;
            }

        }


    }
}
