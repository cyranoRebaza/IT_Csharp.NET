using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             PARAMETROS:
                - un parametro es un dato que ingresa a una funcion o procedimiento
                  a travez de su llamada

            PASAR PARAMETROS POR VALOR:
                - se pasa una copia del objeto
                - los cambios realizados en el objeto copia no afecta al objeto original

            PASAR PARAMETROS POR REFERENCIA --> palabra clave: ref - out - in
                - los cambios realizados en el objeto copia no afecta al objeto original
             */

            int valorAr = 20;
            Console.WriteLine($"En el main valor = {valorAr} ");

            // llamo a la metodo ModificarValor()
            ModificarValor(valorAr);

            Console.WriteLine($"Volviendo al Main, valorAr = {valorAr}");

            Console.WriteLine("**************************************");

            int valor1Ar = 50;
            Console.WriteLine($"En el main valor = {valor1Ar} ");

            // llamo a la metodo ModificarValor1()
            ModificarValor1(ref valor1Ar);

            Console.WriteLine($"Volviendo al Main, valorAr = {valor1Ar}");
        }

        // metodo para parametros por valor
        static void ModificarValor( int valorPa)
        {
            valorPa = 30;
            Console.WriteLine($"en ModificaValor() el valor del parametro valorPa = {valorPa}");
        }

        // metodo para parametros por referencia
        static void ModificarValor1(ref int valor1Pa)
        {
            valor1Pa = 30;
            Console.WriteLine($"en ModificaValor1() el valor del parametro valorPa = {valor1Pa}");
        }
    }
}
