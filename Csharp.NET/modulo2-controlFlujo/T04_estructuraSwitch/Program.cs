using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04_estructuraSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            ESTRUCTURA switch

            opcion: tipo entero, char, string

            switch (opcion) 
            {
                case 1:
                    sentencia1;
                    ...
                    break;

                case 2:
                    sentencia2;
                    ...
                    break;

                case N:
                    sentenciaN:
                    ...
                    break;

                default:
                    sentencia default;
                    ...
                    break;            

            }


             */

            // declaro e inicializo el argumento que tendra switch
            int opcion = 30;


            switch (opcion)
            {
                case 10:
                    Console.WriteLine("DIEZ");
                    break;

                case 20:
                case 30:
                    Console.WriteLine("VEINTE O TREINTA");                    
                    break;               

                default:
                    Console.WriteLine("DEFAULT");                    
                    break;
                    

            }


        }
    }
}
