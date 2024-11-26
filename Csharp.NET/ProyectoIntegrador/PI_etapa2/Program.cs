using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_etapa2
{
    internal class Program
    {
        /*************************** METODOS ***************************/
        static void CargarDatosDelAlumno(ref string nombre, ref string apellido, ref int edad, ref string email)
        {
            Console.WriteLine("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu email: ");
            email = Console.ReadLine();
        }

        static void MostrarDatosDelAlumno(ref string nombre, ref string apellido, ref int edad, ref string email)
        {
            Console.WriteLine("<<<< Datos del alumno >>>>\n");

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Email: {email}");
        }

        static void SolicitarCodigoDeCarrera(ref int codigoCarrera, ref string carreraSeleccionada)
        {
            Console.WriteLine("\n**** Menu carrera ****\n");
            Console.WriteLine("1. Programacion .Net");
            Console.WriteLine("2. Programacion Java");
            Console.WriteLine("3. Programacion PHP");

            Console.Write("\nSeleccione el codigo de la carrera elegida: ");
            codigoCarrera = Convert.ToInt32(Console.ReadLine());

            if (codigoCarrera == 1 || codigoCarrera == 2 || codigoCarrera == 3)
            {
                
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
                

            }
        }

        static void MostrarConstanciaDeInscripcion(string nombre, string apellido, string email, string carreraSeleccionada)
        {
            Console.WriteLine("\n<<<< Constancia de inscripcion >>>>\n");
            Console.WriteLine($"Alumno: {nombre} {apellido}");
            Console.WriteLine($"Correo electronico: {email}");
            Console.WriteLine($"Carrera: {carreraSeleccionada}");
        }

        static void cargarCursosCarrreras(ref string[] cursosNET, ref string[] cursosJava, ref string[] cursosPHP)
        {
            // se cargan los 3 arreglos con cursos de cada carrera
            cursosNET[1] = "Desarrollo Web con HTML";
            cursosNET[2] = "Introduccion al paradigma de Objetos";
            cursosNET[3] = "Introducción a Bases de Datos y SQL";
            cursosNET[4] = "Javascript desde cero";
            cursosNET[5] = "C# .NET para no programadores";

            cursosJava[1] = "Desarrollo Web con HTML";
            cursosJava[2] = "Introduccion al paradigma de Objetos";
            cursosJava[3] = "Introducción a Bases de Datos y SQL";
            cursosJava[4] = "Javascript desde cero";
            cursosJava[5] = "Java para no programadores";

            cursosPHP[1] = "Desarrollo Web con HTML";
            cursosPHP[2] = "Introduccion al paradigma de Objetos";
            cursosPHP[3] = "Introducción a Bases de Datos y SQL";
            cursosPHP[4] = "Javascript desde cero";
            cursosPHP[5] = "Programacion Web en PHP y MySQL";

        }

        static int MostrarCursosCarrreras(string[] cursosNET, string[] cursosJava, string[] cursosPHP, int codigoCarreraSeleccionada)
        {
            int codigoCurso;
            string subtitulo = "\n**** cursos disponibles ****\n";

            switch (codigoCarreraSeleccionada)
            {
                case 1: //net
                    Console.WriteLine("Carrera: Programacion NET");
                    Console.WriteLine(subtitulo);

                    for (int i = 1; i < cursosNET.Length; i++)
                    {
                        Console.WriteLine($"{i}. {cursosNET[i]}");
                    }
                    break;

                case 2: // java
                    Console.WriteLine("Carrera: Programacion Java");
                    Console.WriteLine(subtitulo);

                    for (int i = 1; i < cursosJava.Length; i++)
                    {
                        Console.WriteLine($"{i}. {cursosJava[i]}");
                    }
                    break;

                case 3: // PHP
                    Console.WriteLine("Carrera: Programacion PHP");
                    Console.WriteLine(subtitulo);

                    for (int i = 1; i < cursosPHP.Length; i++)
                    {
                        Console.WriteLine($"{i}. {cursosPHP[i]}");
                    }
                    break;
            }

            Console.Write("Ingrese el codigo de curso al cual desea inscribirse: ");
            codigoCurso = Convert.ToInt32(Console.ReadLine());
            
            return codigoCurso;
        }

        static void MostrarConstanciaDeInscripcionFinal(string nombre, 
                                                        string apellido, 
                                                        string email, 
                                                        string carreraSelecionada, 
                                                        int codigoCarrera,
                                                        string[] cursosNET,
                                                        string[] cursosJava,
                                                        string[] cursosPHP,
                                                        bool[] cursosSeleccionados)
        {
            Console.Clear();
            MostrarConstanciaDeInscripcion(nombre, apellido, email, carreraSelecionada);

            Console.WriteLine("\nCursos: ");
            switch(codigoCarrera)
            {
                case 1: //net
                    
                    for (int i = 1; i < cursosNET.Length; i++)
                    {
                        if (cursosSeleccionados[i])
                        {
                            Console.WriteLine($"{i}. {cursosNET[i]}");
                        }
                    }
                    break;

                case 2: // java
                    
                    for (int i = 1; i < cursosJava.Length; i++)
                    {
                        if (cursosSeleccionados[i])
                        {
                            Console.WriteLine($"{i}. {cursosJava[i]}");
                        }
                    }
                    break;

                case 3: // PHP
                    

                    for (int i = 1; i < cursosPHP.Length; i++)
                    {
                        if (cursosSeleccionados[i])
                        {
                            Console.WriteLine($"{i}. {cursosPHP[i]}");
                        }
                    }
                    break;

            }
            

        }



        /*************************** MAIN ***************************/
        static void Main(string[] args)
        {
            Console.WriteLine("\n**** PROYECTO INTEGRADOR - ETAPA2 ****\n");

            // declaracion variables
            string nombre = "";
            string apellido = "";
            int edad = 0;
            string email = "";

            char respuesta;
            int codigoCarrera = 0;
            string carreraSeleccionada = "";

            int codigoCurso = 0;

            string[] cursosNET = new string[6];
            string[] cursosJava = new string[6];
            string[] cursosPHP = new string[6];
            bool[] cursosSeleccionados = new bool[6];

            // carga de datos
            CargarDatosDelAlumno(ref nombre, ref apellido, ref edad, ref email);
            Console.Clear();

            // muestro los datos cargados
            MostrarDatosDelAlumno(ref nombre, ref apellido, ref edad, ref email);

            // pido confirmacion si lo datos son correctos o no
            Console.Write("\nLos datos son correctos - 'S' para confirmar 'N' para cancelar: ");
            respuesta = Convert.ToChar(Console.ReadLine());

            if (respuesta == 's' || respuesta == 'S')
            {
                // puedo solicitar el codigo de carrera y muestro la constancia de inscripcion
                Console.Clear();

                SolicitarCodigoDeCarrera(ref codigoCarrera, ref carreraSeleccionada);
                MostrarConstanciaDeInscripcion(nombre, apellido, email, carreraSeleccionada);
               

                if (codigoCarrera == 1 || codigoCarrera == 2 || codigoCarrera == 3)
                {
                    cargarCursosCarrreras(ref cursosNET, ref cursosJava, ref cursosPHP);

                    do
                    {
                        Console.Clear();
                        codigoCurso = MostrarCursosCarrreras(cursosNET, cursosJava, cursosPHP, codigoCarrera);

                        if (codigoCurso >= 1 && codigoCurso <= 5)
                        {
                            cursosSeleccionados[codigoCurso] = true;
                        }
                        else
                        {
                            Console.WriteLine("Curso inexistente");
                        }

                        Console.Write("\nDesea cargar cursos - 'S' para confirmar 'N' para cancelar: ");
                        respuesta = Convert.ToChar(Console.ReadLine());
                    }
                    while (respuesta == 's'  || respuesta == 'S');



                }
                else
                {
                    Console.WriteLine("Carrera inexistente");
                    Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicacion");
                }

                MostrarConstanciaDeInscripcionFinal( nombre, apellido, email, carreraSeleccionada, codigoCarrera,
                                                      cursosNET,cursosJava, cursosPHP, cursosSeleccionados);

                Console.WriteLine("Presione una tecla para finalizar");


            }
            else
            {
                Console.WriteLine("Datos incorrectos. Ejecute nuevamente la aplicacion");
            }

            Console.ReadKey();
        }
    }
}
