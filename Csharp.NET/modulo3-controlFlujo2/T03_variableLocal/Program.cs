using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_variableLocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicializacion: int i = 0 --> variable que existe mientras existe for, una vez ejecutado
            // se libera la variables y espacio de memoria
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }

            // puedo inicializar varias variables que sean del mismo tipo, lo mismo con la PostAccion
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine("*");
            }

        }
    }
}
