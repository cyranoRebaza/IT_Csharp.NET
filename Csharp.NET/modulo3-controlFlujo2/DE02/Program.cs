using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Una persona desea invertir $1000 en un banco, el cual le otorga un 3% de interés mensual.

            ¿En cuantos meses conseguirá $1200, si reinvierte cada mes todo su dinero?.
             */

            float dinero = 1000f;
            int mes = 1;

            while (mes <= 12 )
            {
                dinero = dinero * 1.03f;
                if (dinero >= 1200f)
                {
                    break;
                }

                mes++;
            }
            Console.WriteLine($"mes: {mes}");
            Console.WriteLine($"dinero: {dinero}");

            Console.WriteLine("************************************");

            while (dinero <= 1200f)
            {
                dinero = dinero * 1.03f;
                mes++;
            }
            Console.WriteLine($"mes: {mes}");
            Console.WriteLine($"dinero: {dinero}");
        }
    }
}
