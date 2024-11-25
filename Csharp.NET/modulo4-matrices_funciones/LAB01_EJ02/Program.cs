using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Copiar el contenido del arreglo origen al arreglo destino utilizando una estructura de control de
            flujo repetitiva y, luego, informar el índice y los valores del arreglo destino.
             
             */

            int[] origen = { 1, 2, 3, 4 , 5 };

            int[] destino = new int[origen.Length];

            // copio los valores
            for (int i = 0; i < origen.Length; i++)
            {
                destino[i] = origen[i];
            }

            // muestro los valores e indice del arreglo destino
            for (int i = 0; i < origen.Length; i++)
            {
                Console.WriteLine($"valores: {destino[i]} en el indice {i}");
            }




        }
    }
}
