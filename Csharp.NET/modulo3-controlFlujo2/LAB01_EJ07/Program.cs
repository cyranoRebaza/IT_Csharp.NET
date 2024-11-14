using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Imprimir la siguiente figura:
            @
            @@
            @
            @@
            @
             */

            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("@");
                }
                else
                {
                    Console.WriteLine("@@");
                }
            }
        }
    }
}
