using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_EJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Dado el siguiente código:
            usuario = “Pepito”, clave= “1234”

            Informar los siguientes casos:

            - Si usuario = “Pepito” y clave= “1234”
                informar Bienvenido pepito!”.

            - Si usuario = “Pepito” y clave no es “1234”
                informar “Usuario incorrecto”.

            - Si usuario no es “Pepito” y clave= “1234”
                informar “Contraseña incorrecta”.             
             
             */

            //declaramos usuario y clave
            string usuario;
            int clave;

            //solicito usuario y clave
            Console.WriteLine("Ingrese su usuario:");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            clave = int.Parse(Console.ReadLine());


            Console.WriteLine("");
            if (usuario == "cyrano")
            {

                if (clave == 1234)
                {
                    Console.WriteLine("Bienvenido Cyrano");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }

            }
            else
            {
                Console.WriteLine("Usuario no existe");
            }

            
            /*
            // METODO 2:

            //declaro las variable, tipo string
            string usuario = "cyrano";
            string clave = "1234";

            //solicito usuario y clave
            Console.WriteLine("Ingrese su usuario:");
            usuario = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            clave = (Console.ReadLine());




            if (usuario.Equals("cyrano") & clave.Equals("1234"))
            {
                Console.WriteLine("Bienvenido Cyrano");
            }
            if (!(usuario.Equals("cyrano")) & clave.Equals("1234"))
            {
                Console.WriteLine("usuario no existe");
            }
            if (usuario.Equals("cyrano") & !(clave.Equals("1234")))
            {
                Console.WriteLine("clave incorrecta");
            }

            */

            
            
            Console.ReadKey();

        }
    }
}
