using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Copiar el contenido del arreglo origen al arreglo destino, 
            dejando en este último los valores invertidos respecto del arreglo origen. 
            Utilizar  estructura de control de flujo repetitiva, y luego
            informar el índice y los valores del nuevo vector.

             */

            int[] origen = { 1, 2, 3, 4 };
            int[] destino = new int[origen.Length];


            for (int i = 0; i < origen.Length; i++)
            {
              
                destino[i] = origen[origen.Length - i - 1];
            }

            for (int i = 0; i < origen.Length; i++)
            {
                Console.WriteLine($"Indice {i}, valor: {destino[i]}");
            }

        }
    }
}
