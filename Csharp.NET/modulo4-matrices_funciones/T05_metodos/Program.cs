using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - un problema se divide el subproblemas conocidos como modulos su implementacion
            se llaman SUBPROGRAMAS

            - los subprogramas se clasifican en procedimientos y funciones, en c# conone como METODOS

            *********************************************
            
             FUNCIONES: (retornan un valor)

                - continiene secuencia de instruciones que realiza tarea especifica

                - NOMBRE:tienen un nombre unico (salvo el sobrecarga o polimorfismo)

                - TIPO DE DATO RETORNO: tipo de dato que devolvera la funcion al terminar su ejecucion

                - PAREMETROS: varibles que recibe la funcion par realizar su tarea

                SINTAXIS:
                ModificadorAcceso TipoDatoDevuelto Nombre_funcion(parametros)
                {
                    // cuerpo de la funcion

                    retur (valor);
                }

                *********************************************
            
                PROCEDIMIENTOS: (no retorna un valor)

                - reciben parametros, pero no necesitan devolver un valor

                SINTAXIS:
                    ModificadorAcceso void TipoDatoDevuelto Nombre_funcion(parametros)
                    {
                        // cuerpo de la funcion
                        
                    }

             
             */

            // Ejemplo1: usando funcion, calcular la suma de dos numeros

            Console.Write($"Ingrese un numero: ");
            int num1Ar = Convert.ToInt32( Console.ReadLine() );

            Console.Write($"Ingrese un numero: ");
            int num2Ar = Convert.ToInt32(Console.ReadLine());

            // llammo a la funcion sumar lo que devuleve lo guargo en la varible suma
            int suma = Sumar(num1Ar,num2Ar);

            Console.WriteLine($"La suma es: {suma}");

            Console.WriteLine("***********************************************");

            // Ejemplo2: usando procedimiento, calcular la resta de dos numeros
            Console.Write($"Ingrese un numero: ");
            int num3Ar = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Ingrese un numero: ");
            int num4Ar = Convert.ToInt32(Console.ReadLine());

            // llamo al procedimiento Restar
            Restar(num3Ar, num4Ar);


        }

        // funcion sumar:
        static int Sumar(int num1Pa, int num2Pa)
        {
            int resultado = num1Pa + num2Pa;
            return resultado;
        }

        // procedimiento restar:
        static void Restar(int num1Pa, int num2Pa)
        {
            int resultado = num1Pa - num2Pa;
            Console.WriteLine($"La resta es: {resultado}");
        }
    }
}
