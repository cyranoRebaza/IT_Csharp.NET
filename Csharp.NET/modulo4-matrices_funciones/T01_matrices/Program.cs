using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Inicializacion de un arreglo
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            
                        
            // mostrar tipos de dato
            Console.WriteLine(numeros); //System.Int32[] --> direccion de memoria

            Console.WriteLine("**************************\n");

            // Imprimir un dato que contiene el arreglo
            Console.WriteLine(numeros[0]);

            Console.WriteLine("**************************\n");

            // Imprimir todos los datos
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            
            Console.WriteLine("**************************\n");

            // copia de arreglos
            int[] numerosCopia = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                numerosCopia[i] = numeros[i];
                
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numerosCopia[i]);
                
            }
        }
    }
}
