using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_arrayBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ARREGLO BIDIMENSIONAL
                
                DECLARACION E INSTANCIACION
                tipo[,] identificador;
                identificador = new tipo[F,C];

                INICIALIZACION
                tipo[,] identificador = {{}, {}};
             */

            // declaracion array
            int[,] matriz = new int[2, 3];

            // escritura  de un dato
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            // lectura de un dato
            Console.WriteLine(matriz[0, 0]);

            Console.WriteLine("**********************");
            Console.WriteLine("Matriz");

            // inicializacion de una matriz 2*3
            int[,] numeros = {
                {15, 28, 32 },
                {87, 95, 100 }
            };

            // Imprimir la matriz
            for (int i = 0; i < numeros.GetLength(0); i++) // recorre fila
            {
                for (int j = 0; j < numeros.GetLength(1); j++) // recorre columnas
                {
                    Console.Write($"{numeros[i,j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("**********************");

            // crear una matriz y llenamos con numeros aleatorioa positivos menores a 100
            const int MAX_FILAS = 2;
            const int MAX_COLUMNAS = 10;

            Random rand = new Random();

            Console.WriteLine("Matriz2");

            int[,] matriz2 = new int[MAX_FILAS, MAX_COLUMNAS];

            for (int i = 0; i < MAX_FILAS; i++)
            {
                for (int j = 0; j < MAX_COLUMNAS; j++)
                {
                    matriz2[i, j] = rand.Next(100);
                    Console.WriteLine($"matriz[{i},{j}] = {matriz2[i,j]}");
                }
            }




        }
    }
}
