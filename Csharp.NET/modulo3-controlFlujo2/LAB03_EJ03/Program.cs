using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Agregar los cambios que resulten necesarios al
            ejercicio anterior para que en los puntos 2 y 3 se
            informe la inflación junto con el nombre del mes.

            EJEMPLO: mes FEBRERO = 0.1
             */

            // declaracion e inicializacion del array inflacion y de los meses del anio
            double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };

            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            //variables punto1
            double inflacionAnual = 0;

            // variables punto2
            double inflacionMenor = inflacion[0];
            string mes_inflacionMenor = "";

            // variables punto3
            double inflacionMayor = inflacion[0];
            string mes_inflacionMayor = "";

            // variables punto4
            double promedioInflacion;
            int cantidadElementos = 0;

            //punto1:
            for (int i = 0; i < inflacion.Length; i++)
            {
                inflacionAnual += inflacion[i];
            }

            Console.WriteLine($"La inflacion anual es: {inflacionAnual}");

            Console.WriteLine("\n******************************\n");

            // punto2:
            for (int i = 0; i < inflacion.Length; i++)
            {
                if (inflacion[i] < inflacionMenor)
                {
                    inflacionMenor = inflacion[i];
                    mes_inflacionMenor = mes[i];

                }
            }

            Console.WriteLine($"La menor inflacion es: {inflacionMenor} en el mes = {mes_inflacionMenor}");

            Console.WriteLine("\n******************************\n");

            // punto3:
            for (int i = 0; i < inflacion.Length; i++)
            {
                if (inflacion[i] > inflacionMayor)
                {
                    inflacionMayor = inflacion[i];
                    mes_inflacionMayor = mes[i];

                }
            }

            Console.WriteLine($"La mayor inflacion es: {inflacionMayor} en el mes = {mes_inflacionMayor}");

            Console.WriteLine("\n******************************\n");

            // punto4:            
            for (int i = 0; i < inflacion.Length; i++)
            {
                cantidadElementos++;
            }
            promedioInflacion = inflacionAnual / cantidadElementos;

            Console.WriteLine($"El promedio de inflacion es: {promedioInflacion}");
        }
    }
}
