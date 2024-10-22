using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_operadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * OPERADOR TERNARIO: evalua una condicion --> devuelve verdadero o falso
             * 
             * SINTAXIS: 
             *  condicion ? valor_si_verdadero : valor_si_falso 
             *  
             *  NOTA: similar a la estructura condicional if-else --> cuando se necesita elegir entre dos valores
             
             */

            // declaro variable
            int edad = 20;

            // pregunto si es mayor de edad
            string resultado = (edad >= 18) ? "Mayor de edad" : "Menor de edad";

            // muestro resultado
            Console.WriteLine(resultado);

        }
    }
}
