using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 6 - Cadena de caracteres");
            Console.WriteLine("");

            Console.WriteLine("Consigna A");
            Console.WriteLine("");
            string palabra_1 = "Hola";
            string palabra_2 = "Mundo";
            string frase = "";

            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("..........");
            Console.WriteLine("Consigna B");
            Console.WriteLine("");
            frase = palabra_1 + palabra_2;

            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("");
            Console.WriteLine("..........");
            Console.WriteLine("Consigna C");
            frase = palabra_1 + " \t " + palabra_2;    // caracter de escape (\) haga tabulacion (t)

            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);

            Console.WriteLine("");
            Console.WriteLine("..........");
            Console.WriteLine("Consigna D");
            frase = palabra_1 + " \n " + palabra_2;   // caracter de escape (\) haga salto del linea (n)
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);


            Console.WriteLine("");
            Console.WriteLine("..........");
            Console.WriteLine("Consigna E");
            frase = palabra_1 + " \n \t " + palabra_2;   // tener en cuenta los espacios entre cada caracter  de escape
            Console.WriteLine(palabra_1);
            Console.WriteLine(palabra_2);
            Console.WriteLine(frase);





            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
