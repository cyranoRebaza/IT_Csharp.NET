using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08_operadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            OPERADORES RELACIONALES

            - <: menor 
            - >: mayor 
            - <=: menor o igual 
            - ==: igual
            - !=: distinto 
               
            
              
             
             */

            // declaro variables
            bool valorLogico;
            byte x = 15;

            valorLogico = (23 < 40);

            Console.WriteLine("23 < 40 " + valorLogico);

            valorLogico = (x >= 30);

            Console.WriteLine("x >= 30 " + valorLogico);

            valorLogico = (x == 15);
            
            Console.WriteLine("x == 15 " + valorLogico);
            
            valorLogico = (x != 15);
            
            Console.WriteLine("x != 15 " + valorLogico);
        }
    }
}
