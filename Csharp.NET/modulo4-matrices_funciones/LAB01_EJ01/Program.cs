using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ingrese por teclado la facturación de los últimos 6 meses (se ingresa un importe por cada mes).
            Solo se pueden ingresar números.
            Informar
            1. La facturación total (sumatoria).
            2. El promedio de facturación de los últimos 6 meses.
            3. El valor máximo facturado.
            4. El valor mínimo facturado

             */

            // Declaracion array facturacion
            double[] facturacion = new double[6];

            const int MES = 6;
            double facturacionMes;
            double facturacionTotal = 0;
            double facturacionPromedio = 0;
            double maximo =0;
            double minimo = 0;

            // cargar la facturacion
            for (int i = 0; i < MES; i++)
            {
                Console.Write("Ingrese la facturacion del mes: ");
                facturacionMes = Convert.ToDouble(Console.ReadLine());
                facturacion[i] = facturacionMes;
            }

            for (int i = 0; i < MES; i++)
            {
                // punto1:
                facturacionTotal += facturacion[i];

                // punto2:
                facturacionPromedio = facturacionTotal / MES;

                // punto3:
                if (i == 0)
                {
                    maximo = facturacion[0];
                }
                else if (facturacion[i] > maximo)
                {
                    maximo = facturacion[i];
                }

                if (i == 0)
                {
                    minimo = facturacion[0];
                }
                else if (facturacion[i] < minimo)
                {
                    minimo = facturacion[i];
                }

            }

            Console.WriteLine($"facturacion total: {facturacionTotal}");
            Console.WriteLine($"facturacion promedio: {facturacionPromedio}");
            Console.WriteLine($"valor maximo: {maximo}");
            Console.WriteLine($"valor minimo: {minimo}");
            
        }
    }
}
