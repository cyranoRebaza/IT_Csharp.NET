using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Realizar un programa que solicite al usuario dos
            números y la operación a realizar para mostrar
            su resultado; y tenga dos funciones que sean
            capaces de realizar una suma y una resta.
             
             */

            // declaracion de variables
            int numero1Ar;
            int numero2Ar;
            int suma;
            int resta;

            // pido los numeros al usuario
            Console.Write("Ingrese numero: ");
            numero1Ar = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingrese numero: ");
            numero2Ar = Convert.ToInt32(Console.ReadLine());

            // llamo la funcion Sumar();
            suma = Sumar(numero1Ar, numero2Ar);

            // llamo la funcion Restar();
            resta = Restar(numero1Ar, numero2Ar);

            // muestro
            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"La resta es: {resta}");



        }

        // metodo sumar:
        static int Sumar(int numero1Pa, int numero2Pa)
        {
            int resultado = numero1Pa + numero2Pa;
            return resultado;
        }

        // metodo restar:
        static int Restar(int numero1Pa, int numero2Pa)
        {
            int resultado = numero1Pa - numero2Pa;
            return resultado;
        }
    }
}
