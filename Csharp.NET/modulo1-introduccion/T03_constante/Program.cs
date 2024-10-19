using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_constante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             CONSTANTE: compilador reserva espacio de memoria para almacenar el dato --> sera el mismo
                
            SINTAXIS: 
                const <tipoDato> <nombreVariable>;
             */

            // declaracion variables y constantes
            double perimetro;
            double area;
            double radio = 4;
            
            const double PI = 3.1415926; // se declara e inicializa
            

            //calculo el perimetro y el area de la circunferencia
            perimetro = 2 * PI * radio;
            area = PI * Math.Pow(radio, 2);

            // muestro area y el perimetro
            Console.WriteLine($"el perimetro de la circunferencia de radio {radio} es: {perimetro}");
            Console.WriteLine($"el area de la circunferencia de radio {radio} es: {area}");

            
        }
    }
}
