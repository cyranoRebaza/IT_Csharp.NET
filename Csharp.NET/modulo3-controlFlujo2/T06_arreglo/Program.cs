using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace T06_arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             DECLARACION DE UN ARREGLO: en 2 pasos
                        
            tipo[] indentificador;
            identificador = new tipo[N]; // pido la memoria para la cantidad de variables

            DECLARACION DE UN ARREGLO: en 1 paso
                        
            tipo[] indentificador = new tipo[N];

            ********************************************

            RECORRIDO  DEL ARRAY

            for(i=0; i < losValores.Length; i++)
            {
            Console.WriteLine(losValores[i]);
            }

             
             */

            // arreglo temperaturas que contiene 10 variables tipo float
            float[] temperaturas; // declaracion array
            temperaturas = new float[10]; //Instanciacion del array

            // ESCRITURA en las variables del arreglo temperatura
            temperaturas[0] = 14.23f;
            temperaturas[3] = 27.18f;

            // LECTURA de las variables del arreglo
            Console.WriteLine(temperaturas[0]);

            // RECORRIDO del array
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine(temperaturas[i]);
            }

            Console.WriteLine("*******************************");

            // arreglo nombres que contiene 6 variables tipo string
            string[] nombres = new string[6];

            // ESCRITURA en las variables del arreglo nombres
            nombres[2] = "Jose";
            nombres[5] = "Pepe";

            // LECTURA de las variables del arreglo
            Console.WriteLine(nombres[2]);

            // RECORRIDO del array
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Console.WriteLine("*******************************");

            // INICIALIZACION de un arreglo
            int[] numeros = { 1, 2, 3, 4, 5 };

            // RECORRIDO del array
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
