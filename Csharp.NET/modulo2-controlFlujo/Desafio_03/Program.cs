using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Ingresar 2 notas de parciales de un alumno,e informar 
            si está aprobado, desaprobado o si debe recuperar el primer parcial o el segundo, 
            sabiendo que la nota mínima de aprobación es 4 y se deben aprobar los 2 parciales.
             
             */

            // declar las varaibles
            int parcial1;
            int parcial2;

            // pido las notas
            Console.Write("Ingrese la nota del parcial 1: ");
            parcial1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la nota del parcial 2: ");
            parcial2 = Convert.ToInt32(Console.ReadLine());

            if ((parcial1 >= 4) && (parcial2 >= 4))
            {
                Console.WriteLine("APROBADO");
            }
            else if ((parcial1 >= 4) || (parcial2 < 4))
            {
                Console.WriteLine("RECUPERA PARCIAL 2");
            }
            else if ((parcial1 < 4) || (parcial2 >= 4))
            {
                Console.WriteLine("RECUPERA PARCIAL 1");                
            }
            else
            {
                Console.WriteLine("DESAPROBADO");
            }

            Console.ReadKey();
        }
    }
}
