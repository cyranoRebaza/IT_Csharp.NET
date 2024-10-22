using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_decisionDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            ESTRUCTURA CONDICIONAL: if-else

            -sintaxis:

            if(condicion){
                sentencia1_if;
                sentencia2-if;
                .....
                sentenciaN_if;
            }
            else
            {
                sentencia1_else;
                sentencia2-else;
                .....
                sentenciaN_else;
            }
                             
             
             */

            // declaro las variables
            byte x = 3;

            // pregunto
            if (x > 5)
            {
                x++;
            }
            else
            {
                x--;
                x *= 3;
            }

            Console.WriteLine($"x: {x}");

        }
    }
}
