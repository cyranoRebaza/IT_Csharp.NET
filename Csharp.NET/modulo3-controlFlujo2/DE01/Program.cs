using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Una persona desea invertir $1000 en un banco, el cual le otorga un 2% de interés mensual.
            ¿Cuál será la cantidad de dinero que esta persona tendrá al cabo de un año?.

            En el primer mes tendrá acumulado $1000 más $20 de interés ( 2% de 1000 ). En el segundo mes
            se le sumará un 2% a la base de $1020 del mes  anterior y así sucesivamente. 
             
             */

            // METODO1:
            float[] inversionMensual = new float[12];           

            float inversion = 1000;
            float interesMensual = 1.02f;

            for (int i = 0; i < inversionMensual.Length; i++)
            {
                inversion *= interesMensual;
            }

            Console.WriteLine($"Dinero anual: {inversion}");

            Console.WriteLine("\n***********************\n");

            // METODO2:
            float dinero = 1000f;
            int mes = 1;

            while (mes <= 12)
            {
                dinero *= 1.02f;
                mes++;
            }
            Console.WriteLine($"Dinero anual: {dinero}");




        }
    }
}
