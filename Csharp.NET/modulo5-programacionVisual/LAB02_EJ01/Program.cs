using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METODO1:
            // tomamos cada valor
            IVA tipo1 = IVA.general;
            IVA tipo2 = IVA.reducido;
            IVA tipo3 = IVA.superreducido;
            IVA tipo4 = IVA.exento;

            // pasamos de enumeracio a enteros
            int valor1 = (int)tipo1;
            int valor2 = (int)tipo2;
            int valor3 = (int)tipo3;
            int valor4 = (int)tipo4;

            // mostrar los valores junto con sus equivalentes numericos
            Console.WriteLine("tipos de IVA");
            Console.WriteLine("*************");
            Console.WriteLine($"{tipo1}: {valor1} %");
            Console.WriteLine($"{tipo2}: {valor2} %");
            Console.WriteLine($"{tipo3}: {valor3} %");
            Console.WriteLine($"{tipo4}: {valor4} %");

            Console.WriteLine("\n****************************\n");

            // METODO2:
            // Declaro las variables de la enumeracion
            IVA[] tipos = { IVA.general, IVA.reducido, IVA.superreducido, IVA.exento };

            // Declaramos un array  para los valores numericos
            int[] valoresNumericos = new int[tipos.Length];

            // convertimos a enteros
            for (int i = 0; i < tipos.Length; i++)
            {
                valoresNumericos[i] = (int)tipos[i];
            }

            // mostramos los valores
            for (int i = 0; i < tipos.Length; i++)
            {
                Console.WriteLine($"{tipos[i]}: {valoresNumericos[i]}%");
            }




        }
    }

    public enum IVA { general = 21, reducido = 10, superreducido = 4, exento = 0 };
}

/*
Crear una enumeración que liste los diferentes tipos de IVA.

Codificar una aplicación de consola que muestre
todos los valores posibles de la enumeración.
 */
