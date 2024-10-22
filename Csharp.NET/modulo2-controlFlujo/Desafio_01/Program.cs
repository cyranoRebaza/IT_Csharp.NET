using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar una nota de un alumno, e informar
            si está aprobado, si recupera o si promociona la materia.

            Datos
            Se aprueba con nota 4, 5 o 6 y se promociona con nota igual o superior a 7.
             
             
             */

            // declaracion variables
            int nota;

            // pido la nota
            Console.Write("Ingrese la nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if(nota >= 7)
            {
                Console.WriteLine("PROMOCIONA");
            }
            else if (nota >= 4)
            {
                Console.WriteLine("APROBADO");
            }
            else
            {
                Console.WriteLine("RECUPERA");
            }

            Console.ReadKey();
        }
    }
}
