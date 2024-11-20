using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07_recorridoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion e instanciacion
            int[] numeros = new int[4];

            // escritura en las variables del array
            numeros[0] = 154;
            numeros[1] = 28;
            numeros[2] = -1684;
            numeros[3] = 0;

            // recorrido array
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("****************************\n");

            // recorrido array --> atras para adelante
            for (int i = numeros.Length -1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("****************************\n");

            // buscar el numero maximo y minimo del arreglo
            int maximo = numeros[0];
            int minimo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }                    

            }

            Console.WriteLine($"El valor maximo es: {maximo}");
            Console.WriteLine($"El valor minimo es: {minimo}");

            Console.WriteLine("****************************\n");

            // cuantas veces aparece el numero 28
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 28)
                {
                    contador++;
                }
            }

            Console.WriteLine($"El numero 28 aparece: {contador} veces");

            Console.WriteLine("****************************\n");

            // calcular la suma y el promedio
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine($"La suma total es: {suma}");
            Console.WriteLine($"El promedio es: {suma / numeros.Length}");


            Console.ReadKey();


        }
    }
}
