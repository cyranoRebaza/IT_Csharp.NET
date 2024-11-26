using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_etapa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n**** PROYECTO INTEGRADOR - ETAPA1 ****\n");

            // declaracion variables
            string nombre;
            string apellido;
            int edad;
            string email;

            char respuesta;
            int codigoCarrera;
            string carreraSeleccionada = "";

            // cargo los datos
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu email: ");
            email = Console.ReadLine();

            Console.Clear();

            // muestro los datos cargados
            Console.WriteLine("<<<< Datos del alumno >>>>\n");

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Email: {email}");

            // pedir confirmacion si lo datos son correctos o no
            Console.Write("\nLos datos son correctos - 'S' para confirmar 'N' para cancelar: ");
            respuesta = Convert.ToChar( Console.ReadLine());

            if (respuesta == 's' || respuesta == 'S')
            {
                // puedo solicitar el codigo de carrera
                Console.Clear();

                Console.WriteLine("**** Menu carrera ****\n");
                Console.WriteLine("1. Programacion .Net");
                Console.WriteLine("2. Programacion Java");
                Console.WriteLine("3. Programacion PHP");

                Console.Write("\nSeleccione el codigo de la carrera elegida: ");
                codigoCarrera = Convert.ToInt32(Console.ReadLine());

                if (codigoCarrera == 1 || codigoCarrera == 2 || codigoCarrera == 3)
                {
                    // muestro datos y carrera elegida
                    Console.WriteLine("\n<<<< Constancia de inscripcion >>>>\n");
                    Console.WriteLine($"Alumno: {nombre} {apellido}");
                    Console.WriteLine($"Correo electronico: {email}");

                    switch (codigoCarrera) 
                    {
                        case 1:
                            carreraSeleccionada = "Programacion .Net";
                            break;
                        case 2:
                            carreraSeleccionada = "Programacion Java";
                            break;
                        case 3:
                            carreraSeleccionada = "Programacion PHP";
                            break;                   

                    }
                    Console.WriteLine($"Carrera: {carreraSeleccionada}");

                }
                else
                {
                    Console.WriteLine("Carrera inexistente");
                    Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicacion");
                }


            }
            else
            {
                Console.WriteLine("Datos incorrectos. Ejecute nuevamente la aplicacion");
            }


            Console.ReadKey();
        }
    }
}

/*

Esta etapa deberá incluir: Declaración e inicialización de variables, uso de estructuras
condicionales y salida de datos por pantalla.

1. Realizar una interfaz que solicite al alumno:
    - Nombre.
    - Apellido.
    - Edad.
    - Correo electrónico.

2. Una vez cargados estos 4 datos, mostrar los datos ingresados y pedir al alumno una
confirmación para saber si los datos son correctos. Si se confirman los datos, deberá
solicitar al alumno que seleccione un código de carrera. En caso contrario, pedir que
ejecute nuevamente la aplicación y finalizará.

3. Mostrar por pantalla un mensaje con los datos personales del alumno y la carrera
elegida.

4. En caso de que el código de la carrera seleccionado sea incorrecto, mostrar un 
mensaje de error notificando que la carrera es inexistente, y solicite al alumno
que vuelva a iniciar la aplicación finalizando su ejecución.

 */
