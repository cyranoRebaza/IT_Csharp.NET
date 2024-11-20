using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE03_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion variables
            string claveIngresada = "";
            string claveCorrecta = "pepe";
            int intentos = 3;

            bool banderaClave = false;

            do
            {
                Console.Write("Ingrese clave: ");
                claveIngresada = Console.ReadLine();

                if (claveIngresada == claveCorrecta)
                {
                    banderaClave = true;
                }
                else
                {
                    intentos--;

                    if (intentos > 0)
                    {
                        if (intentos == 2)
                        {
                            Console.WriteLine("Tiene dos intentos");
                        }
                        else if (intentos == 1)
                        {
                            Console.WriteLine("Atencion!! ultimo intento");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("tres intentos fallidos");
                    }
                }
            }
            while (intentos > 0 && !banderaClave);

            if (banderaClave)
            {
                Console.WriteLine("bienvenido");
            }
        }
    }
}
