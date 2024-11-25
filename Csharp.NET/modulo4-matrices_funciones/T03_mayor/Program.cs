using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             calcular el mayor de los elementos de un array, despues hacer los cambios necesarios
            para mostrar tambien el menor
             */
            
            // declaracion e inicializacion array
            int[] datos = { 234, -32, 15, 99, 4532, 1243, 9, -693 };

            // declaracion variables
            int mayor = datos[0];
            int menor = datos[0];

            // recorro el vector desde el segundo elemento
            for (int i = 1; i < datos.Length; i++)
            {
                if (datos[i] > mayor)
                {
                    mayor = datos[i];
                }
                if (datos[i] < menor)
                {
                    menor = datos[i];
                }
            }

            // muestro el mayor y el menor
            Console.WriteLine($"El mayor es: {mayor}");
            Console.WriteLine($"El menor es: {menor}");
        }
    }
}
