using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_estructuras
{
    internal class Program
    {
        // PASO 1: definir una estructura
        public struct DatoCliente
        {
            public string numeroCuenta;
            public string tipoCuenta;
            public string titular;
            public string CBU;
            public double saldo;
        }
        
        
        
        static void Main(string[] args)
        {
            /*
             ESTRUCTURAS:
                - conjunto de datos agrupados para formar un tipo de dato compuesto
                - Es un tipo de dato personalizado 
                - Es un UDT (User Defined Type = Tipo de dato definido por el usuario)
                
                - Se las puede definir a nivel clase o namespace

               
              COMO DEFINIR UNA ESTRUCTURA:

                visibilidad struct nombre{
                    visibilidad tipo campo1;
                    …
                    visibilidad tipo campoN;

                }


             */

            // PASO 2: declaracion e inicializacion directa(sin constructor)
            DatoCliente cliente;

            // PASO 3: acceder a los campos de una variable de tipo estructura
            cliente.numeroCuenta = "0123456";
            cliente.titular = "pepe";
            cliente.saldo = 125.5;

            // mostrar
            Console.WriteLine($"numero cuenta: {cliente.numeroCuenta}");

        }
    }
}
