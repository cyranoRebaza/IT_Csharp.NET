using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_decisionAnidada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            ESTRUCTURA CONDICIONAL: if-else if-else

            -sintaxis:

            if(condicion1)
            {
                sentencia1;
                ...
            }
            else
            {
                if(condicion2)
                {
                sentencia2;
                ...            
                }
                else
                {
                    if(condicion3)
                    {   
                        sentencia3;
                        ...            
                    }
                    else
                    {
                        sentencia3;
                    }
                }

            }


            ESTRUCTURA CONDICIONAL COMPACTA: if-else if-else

            -sintaxis:

            if(condicion1)
            {
                sentencia1;
                ...            
            }
            else if(condicio2)
            {
                condicion2;
                ...
            }
            else if(condicion3)
            {
                condicion3;  
                ...
            }
            else
            {
                condicion3;
                ...
            }            
                             
             
             */

            // declaro las variables
            byte n = 10;

            if (n == 10)
            {
                Console.WriteLine("DIEZ");
            }
            else if (n == 20)
            {
                Console.WriteLine("VEINTE");
            }
            else if (n == 30)
            {
                Console.WriteLine("TREINTA");
            }
            else
            {
                Console.WriteLine("ELSE FINAL");
            }

        }
    }
}
