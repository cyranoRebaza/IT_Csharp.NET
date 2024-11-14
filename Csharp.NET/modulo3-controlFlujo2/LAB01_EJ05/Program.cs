using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Mostrar la resta de la multiplicacion de los numeros del 1 al 5 con la suma de los numeros
            del 1 al 5
            ejemplo: (1*2*3*4*5) - (1+2+3+4+5)
             */

            int multiplicacion = 1;
            int suma = 0;
            int resta = 0;

            for (int i = 1; i <= 5; i++)
            {
                multiplicacion *= i;
                suma += i;
            }

            

            resta = multiplicacion - suma;

            Console.WriteLine($"{multiplicacion} - {suma} = {resta}");
        }
    }
}
