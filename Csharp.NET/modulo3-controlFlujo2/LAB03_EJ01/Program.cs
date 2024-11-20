using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado el arreglo {10,20,5,15,30,20}

                1. Informar el arreglo de la forma: "Indice: X, Valor: Y"

                2. Sumar el los valores de los elementos del arreglo
                e informar el total.

                3. Informar el contenido de las posiciones impares (por
                ejemplo, las posiciones 1, 3, 5, etc).

                4. Informar el número mayor número.

                5. Informar cuántas veces aparece el número 20.
             */

            //declaracion e inicializacion del array
            int[] numeros = { 10, 20, 5, 15, 30, 20 };

            int suma = 0;
            int mayor = numeros[0];
            int contador = 0;

            // punto1: recorro el array 
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Indice: {i}, valor: {numeros[i]}");                                             

            }

            Console.WriteLine("\n*****************************\n");

            // punto2: recorro el array 
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];               
                
            }

            Console.WriteLine($"suma total: {suma}");
            
            Console.WriteLine("\n*****************************\n");

            // punto3: recorro el array 
            for (int i = 0; i < numeros.Length; i++)
            {
                               
                if (i % 2 != 0)
                {
                    Console.WriteLine($"posicion impar: {i} tiene valor:{numeros[i]}");
                }
               
            }

            Console.WriteLine("\n*****************************\n");

            // punto4: recorro el array 
            for (int i = 0; i < numeros.Length; i++)
            {
                      
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                 
            }

            Console.WriteLine($"El mayor es: {mayor}");

            Console.WriteLine("\n*****************************\n");

            // punto5: recorro el array 
            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i] == 20)
                {
                    contador++;
                }
           
            }
                       
            Console.WriteLine($"El 20 aparecio: {contador} veces");

            Console.ReadKey();

            

            
        }
    }
}
