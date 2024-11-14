using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Imprimir la siguiente figura:
            @
            @@
            @@@
            @@@@
            @@@
            @@
            @
                  
                    
           
            */
            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("@");
                        break;
                    case 2:
                        Console.WriteLine("@@");
                        break;
                    case 3:
                        Console.WriteLine("@@@");
                        break;
                    case 4:
                        Console.WriteLine("@@@@");
                        break;
                    case 5:
                        Console.WriteLine("@@@");
                        break;
                    case 6:
                        Console.WriteLine("@@");
                        break;
                    case 7:
                        Console.WriteLine("@");
                        break;
                    
                }
            }
        }
    }
}
