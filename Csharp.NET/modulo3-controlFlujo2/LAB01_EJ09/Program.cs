using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Imprimir la siguiente figura:
            @@@@@
            @@@@
            @@@
            @@
            @        
                    
           
            */

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("@");
                }

                Console.WriteLine("@");
            }
        }
    }
}
