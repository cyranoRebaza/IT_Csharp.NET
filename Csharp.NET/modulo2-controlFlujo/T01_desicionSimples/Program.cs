using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_desicionSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            ESTRUCTURA CONDICIONAL: if

            -sintaxis:

            if(condicion){
                sentencia1;
                sentencia2;
                .....
                sentenciaN;
            }
                

             
             
             */

            // declaro variable
            byte numero1 = 10;
            byte numero2 = 100;

            // pregunto
            if (numero1 < 50)
            {
                numero1++;
                numero1 *= 2;
            }

            if (numero2 < 50) 
            {
                numero2++;            
            }

            // muestro
            Console.WriteLine($"numero1: {numero1}");
            Console.WriteLine($"numero2: {numero2}");

        }
    }
}
