using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Dado un arreglo origen de 12 elementos que representan meses del año 
            (cuyos indices van del 0 al 11), y contiene la facturación
            correspondiente a todo un año, informar la facturación por trimestre. 
            Para esto,armar un  arreglo destino de 4 posiciones, donde cada
            posición contenga la facturación de cada trimestre.
             
             */

            float[] facturacion = { 80, 20, 50, 40, 60, 70, 80, 30, 50, 20, 40, 60 };

            float[] trimestre = new float[4];

            float totalTrimestre1 = 0.0f;
            float totalTrimestre2 = 0.0f;
            float totalTrimestre3 = 0.0f;
            float totalTrimestre4 = 0.0f;

            // calculo de la facturacion trimestral
            for (int i = 0; i < facturacion.Length; i++)
            {
                // trimestre1
                if (i <= 2)
                {
                    totalTrimestre1 += facturacion[i];
                }

                if (i>=3 && i <=5)
                {
                    totalTrimestre2 += facturacion[i];
                }

                if (i>= 6 && i<=8)
                {
                    totalTrimestre3 += facturacion[i];
                }

                if (i>=9)
                {
                    totalTrimestre4 += facturacion[i];
                }
            }

            // guardo la facturacion trimestral
            trimestre[0] = totalTrimestre1;
            trimestre[1] = totalTrimestre2;
            trimestre[2] = totalTrimestre3;
            trimestre[3] = totalTrimestre4;

            // muestro la factutacion trimestral
            for (int i = 0; i < trimestre.Length; i++)
            {
                Console.WriteLine($"trimestre {i+1} tuvo facturacion = {trimestre[i]}");
            }
        }
    }
}
