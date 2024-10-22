using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            A. Ingresar dos números y ofrecer al usuario un menú con las siguientes opciones:
            “1-Suma 2-Resta 3-Multiplicación 4-División”.

            Luego, mostrar el resultado de la operación aritmética elegida.

            B. Definir n1 y n2 como double, ejecutar nuevamente y
            analizar resultado. ¿Qué diferencia existe en la salida?
            ¿Por qué?
             
             */

            //declaro las variables, tipo int
            int n1, n2;
            int opcion;
            int suma, resta, multiplicacion, division;

            //solicito el ingreso de dos numeros
            Console.WriteLine("Ingrese el primer numero:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            n2 = int.Parse(Console.ReadLine());

            // muestro las opciones
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicación");
            Console.WriteLine("4-División");

            Console.WriteLine("");
            Console.WriteLine("Elija una opcion relacionada con la operacion aritmetica:");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (opcion)
            {
                case 1:
                    suma = n1 + n2;
                    Console.WriteLine($"la suma es: {suma}");
                    break;
                case 2:
                    resta = n1 - n2;
                    Console.WriteLine($"la resta es: {resta}");
                    break;
                case 3:
                    multiplicacion = n1 * n2;
                    Console.WriteLine($"la multiplicacion es: {multiplicacion}");
                    break;
                case 4:
                    division = n1 / n2;
                    Console.WriteLine($"la division es: {division}");
                    break;
                default:
                    Console.WriteLine("La opcion ingresada no es correcta");
                    break;
            }

           



            Console.WriteLine("****************************************");
            
            //declaro las variables, tipo double
            double num1, num2;
            int opcion1;
            double suma1, resta1, multiplicacion1, division1;

            //solicito el ingreso de dos numeros
            Console.WriteLine("Ingrese el primer numero:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num2 = double.Parse(Console.ReadLine());

            // muestro las opciones
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("Opciones:");
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicación");
            Console.WriteLine("4-División");

            Console.WriteLine("");
            Console.WriteLine("Elija una opcion relacionada con la operacion aritmetica:");
            opcion1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (opcion1)
            {
                case 1:
                    suma1 = num1 + num2;
                    Console.WriteLine($"la suma es: {suma1}");
                    break;
                case 2:
                    resta1 = num1 - num2;
                    Console.WriteLine($"la resta es: {resta1}");
                    break;
                case 3:
                    multiplicacion1 = num1 * num2;
                    Console.WriteLine($"la multiplicacion es: {multiplicacion1}");
                    break;
                case 4:
                    division1 = num1 / num2;
                    Console.WriteLine($"la division es: {division1}");
                    break;
                default:
                    Console.WriteLine("La opcion ingresada no es correcta");
                    break;
            }

            
            Console.ReadKey();
        }
    }
}
