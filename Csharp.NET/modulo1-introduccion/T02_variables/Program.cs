using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             VARIABLE:
                - Una variable representa una posición en memoria en la que se puede almacenar un valor
                  de un determinado tipo. A esa posición se le da cierto nombre.
                - dentro de una clase --> campo                

            SINTAXIS:
            <tipoVariable> <nombreVarible>;           

            */

            // declara una variable nombre de tipo string
            string nombre;

            // podemos declarar e inicializar una variable
            int edad = 20;

            //pedir nombre asignar en la variable nombre
            Console.WriteLine("como se llama el cliente: ");
            nombre = Console.ReadLine();

            // mostramos el nombre en pantalla
            Console.WriteLine($"El cliente se llama {nombre} y tiene {edad}");


            
        }
    }
}
