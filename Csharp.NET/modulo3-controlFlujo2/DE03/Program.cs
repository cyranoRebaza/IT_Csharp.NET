using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Desarrollar el código que permita a una persona
            ingresar como máximo tres veces su contraseña.

            - En caso de ingreso correcto deberá exhibirse
            la leyenda “Bienvenido!!”, caso contrario se
            mostrará “tres veces fallidas”.

            - Indicar cuantas posibilidades de ingresar el
            código le queda. Por ejemplo, si tiene 2
            posibilidades, informar "Tiene dos chances
            !" y si le queda una última oportunidad
            "Atención!! Ultima oportunidad!"

             */

            // declaracion variables
            string claveIngresada = "";
            string claveCorrecta = "pepe";
            int intentos = 3;

            bool banderaClave = false;

            while (intentos >0 && !banderaClave)
            {
                Console.Write("Ingrese clave: ");
                claveIngresada = Console.ReadLine();

                if (claveIngresada == claveCorrecta)
                {
                    banderaClave=true;
                }
                else
                {
                    intentos--;

                    if (intentos == 2)
                    {
                        Console.WriteLine("Tiene dos intentos");
                    }
                    else if (intentos == 1)
                    {
                        Console.WriteLine("Atencion!! ultimo intento");
                    }
                    else
                    {
                        Console.WriteLine("tres intentos fallidos");
                    }
                }
            }

            if (banderaClave == true)
            {
                Console.WriteLine("bienvendido");
            }


        }
    }
}
