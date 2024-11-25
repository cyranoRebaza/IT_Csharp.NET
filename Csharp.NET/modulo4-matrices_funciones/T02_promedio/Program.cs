using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaracion e Inicializacion array
            int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // declaracion variables
            int suma = 0;
            float promedio;

            // calcular la suma de los elementos
            for (int i = 0; i < datos.Length; i++)
            {
                suma += datos[i];
            }

            // calcular el promedio
            promedio = (float)suma / datos.Length;

            // mostrar el promedio
            Console.WriteLine($"Promedio: {promedio}");



        }
    }
}
