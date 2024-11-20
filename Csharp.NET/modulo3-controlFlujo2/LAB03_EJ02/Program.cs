using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado el arreglo inflación {0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9}
             Donde cada ítem del arreglo representa la inflación de un mes,

            Se pide:
            1. Informar la inflación anual (sumatoria).
            2. Informar la inflación más baja, junto con el
                número de mes. Por ejemplo: Mes 2 = 0.1
            3. Informar la inflación más alta, junto con el
                número de mes. Por ejemplo: Mes 12 = 0.9
            4. Informar el promedio de inflación (inflación total / 12).
             
             */

            // declaracion e inicializacion del array inflacion
            double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };

            //variables punto1
            double inflacionAnual = 0;

            // variables punto2
            double inflacionMenor = inflacion[0];
            int mes_inflacionMenor = 0;

            // variables punto3
            double inflacionMayor = inflacion[0];
            int mes_inflacionMayor = 0;

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
                    mes_inflacionMenor = i + 1;                 
                                        
                }
            }

            Console.WriteLine($"La menor inflacion es: {inflacionMenor} del mes = {mes_inflacionMenor}");

            Console.WriteLine("\n******************************\n");

            // punto3:
            for (int i = 0; i < inflacion.Length; i++)
            {
                if (inflacion[i] > inflacionMayor)
                {
                    inflacionMayor = inflacion[i];
                    mes_inflacionMayor = i + 1;

                }
            }

            Console.WriteLine($"La mayor inflacion es: {inflacionMayor} del mes = {mes_inflacionMayor}");

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
