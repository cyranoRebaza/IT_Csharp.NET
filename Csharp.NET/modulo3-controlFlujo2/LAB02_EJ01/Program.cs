using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Imprimir la siguiente figura:
          
           @@@@@
           @@@          
           @
           @@@ 
           @@@@@

           */

            // declarar variables
            int cantInicial = 5;
            int cantMedia = 1;
            int incremento = -2;
            int contadorLineas = 0;
            

            int cantArrobasLinea = cantInicial;
            int cantFinal = cantInicial - incremento;

            while (cantArrobasLinea != cantFinal || contadorLineas == 0)
            {
                for (int cantArrobas = 1; cantArrobas <= cantArrobasLinea; cantArrobas++)
                {
                    Console.Write("@");
                }

                Console.WriteLine();
                cantArrobasLinea += incremento;
                if (cantArrobasLinea == cantMedia)
                {
                    incremento = (-1) * incremento;
                }

                contadorLineas++;
            }

            




        }
    }
}
