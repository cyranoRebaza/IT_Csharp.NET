using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_tiposDato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            TIPO DATO: ENTEROS
                - byte: 0 a 255 (1 byte)
                - short: -32768 a 32768 ( 2 byte)
                - int: (4 byte)
                - long: (8 byte)

                - sbyte: -128 a 127 (1 byte)
                - ushort: 0 a 65535 ( 2 byte)
                - uint: (4 byte)
                - ulong: (8 byte)

            TIPO DATO: REALES
                - float: precision 7 digitos (4 bytes)
                - double: precision 15 digitos (8 bytes)
                - decimal: precision 28 digitos ( 16 bytes)

            TIPO DATO: CARACTERES
                - char: 1 caracter
                _ string: cadena de caracteres
                

            TIPO DATO: LOGICO
                - bool: true o false

             
             
             */

            // declaro variables
            byte num1;
            short num2;

            ushort num3;

            float num4;
            double num5;
            decimal num6;

            char letra;

            string txt;

            bool variableLogico;

            // asigno
            num1 = 68;
            num2 = 300;
            num3 = 5000;
            num4 = 23.7839565451224568755554587751f;
            num5 = 23.7839565451224568755554587751;
            num6 = 23.7839565451224568755554587751m;

            letra = 'A';
            txt = "Hola Mundo!";

            variableLogico = true;


            // muestro
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(letra);
            Console.WriteLine(txt);
            Console.WriteLine(variableLogico);

            
        }
    }
}
