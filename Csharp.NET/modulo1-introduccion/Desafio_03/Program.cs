using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Haciendo uso de la constante IVA=21, que representa el porcentaje de IVA a aplicar a los
            siguientes productos, cuyo precio sin IVA se indica en la siguiente lista:

                - Remera: $59.90.
                - Pantalón: $99.90.
                - Campera: $149.90.

            Informar los precios con IVA de cada uno.             
             
             */

            Console.WriteLine("\n******* Desafio 3 ********\n");
            Console.WriteLine("");

            //declaro las variables y tipo de datos
            const float IVA = 1.21f;
            float precioRemeraIni = 59.90f;
            float precioPantalonIni = 99.90f;
            float precioCamperaIni = 149.90f;

            float precioRemeraFinal;
            float precioPantalonFinal;
            float precioCamperaFinal;


            //calculo el precio final aplicando iva
            precioRemeraFinal = precioRemeraIni * IVA;
            precioPantalonFinal = precioPantalonIni * IVA;
            precioCamperaFinal = precioCamperaIni * IVA;

            //muestro los precios finales
            Console.WriteLine($"El precio final de la Remera es  : {precioRemeraFinal}");
            Console.WriteLine($"El precio final del pantalon  es : {precioPantalonFinal}");
            Console.WriteLine($"El precio final de la campera es : {precioCamperaFinal}");

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
