using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//nombre del archivo ejecutable(mismo nombre que el proyecto) .exe que se generará
namespace T01_holaMundo
{
    // clase inicial del programa program.cs
    internal class Program
    {
       // punto de entrada a la aplicacion (el codigo dentro del main es el primero en ejecutarse)
        static void Main(string[] args)
        {
            // mostrar por pantalla en contenido entre " " dentro del parentesis
            Console.WriteLine("hola mundo");

            /*
             esto es un comentario
             que se muestra como se comentan varias lineas
             */

            // este es un comentario de una sola linea


            //Espera que el usuario presione una tecla para continuar la ejecucion del programa
            Console.ReadKey();
        }
    }
}
