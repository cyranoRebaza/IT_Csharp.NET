using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Realizar un programa que solicite al usuario dos números y la operación a realizar 
            para mostrar su resultado. El programa deberá tener un menú de opciones para llamar 
            a funciones que realizan las operaciones matemáticas:

            - obtener el mayor entre dos números
            - indicar si un número es múltiplo del otro (usar operador %) 
            - calcular la potencia es decir un número elevado otro número
            (usar Math.Pow()).
             
             */

            // variables
            int numero1Ar;
            int numero2Ar;
            int opcion;

            // menu
            Console.WriteLine("***** MENU *****");
            Console.WriteLine("");
            Console.WriteLine("1. obtener el mayor de los numeros");
            Console.WriteLine("2. indicar si uno es multiplo del otro");
            Console.WriteLine("3. calcular la potencia");
            Console.WriteLine("");

            Console.WriteLine("****************\n");

            Console.Write("Ingrese numero: ");
            numero1Ar = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese numero: ");
            numero2Ar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la opcion que desea realizar");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //llamo la funcion Mayor();
                    int mayor = Mayor(numero1Ar, numero2Ar);

                    // mostrar el mayor
                    Console.WriteLine($"el numero mayor es: {mayor}");
                    break;

                case 2:
                    // llamo a la funcion Multiplo();
                    bool multiplo = Multiplo(numero1Ar, numero2Ar);

                    if (multiplo)
                    {
                        Console.WriteLine($"{numero2Ar} es multiplo de {numero1Ar}");
                    }

                    break;

                case 3:
                    // llamo a la funcion potencia
                    double potencia = Potencia(numero1Ar, numero2Ar);

                    // mostramos la potencia
                    Console.WriteLine($"La potencia de {numero1Ar} eleveado a {numero2Ar} = {potencia}");
                    break;
            }

        }

        // metodo mayor:
        static int Mayor(int numero1Pa, int numero2Pa)
        {
            int mayor = 0;
            if (numero1Pa > numero2Pa)
            {
                mayor = numero1Pa;
            }
            else
            {
                mayor = numero2Pa;
            }

            return mayor;
        }

        // metodo Multiplo
        static bool Multiplo(int numero1Pa,int numero2Pa)
        {
            bool multiplo = false;

            if (numero1Pa % numero2Pa == 0)
            {
                multiplo = true;
            }

            if (numero2Pa % numero1Pa == 0)
            {
                multiplo = true;
            }

            return multiplo;
        }

        // metodo potencia:
        static double Potencia(int numero1Pa, int numero2Pa)
        {
            double potencia;
            potencia = Math.Pow(numero1Pa, numero2Pa);

            return potencia;
        }
    }
}
