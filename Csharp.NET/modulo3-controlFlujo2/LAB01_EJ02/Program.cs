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
             Imprimir los numeros del 1 al 10 salteando de a 2 uno abajo del otro
             */
            for (int i = 1; i < 10; i+= 2)
            {
                Console.WriteLine($"numero ciclo: {i} y numero {i}");
            }
        }
    }
}
