using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] productos = new Producto[3];

            for (int i = 0; i < productos.Length; i++)
            {
                // cargo los campos
                Console.WriteLine("Ingrese el codigo del producto: ");
                productos[i].codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del producto: ");
                productos[i].nombre = Console.ReadLine();

                Console.WriteLine("Ingree el precio del producto: ");
                productos[i].precio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la categoria del producto: ");
                productos[i].categoria = Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("Datos de los productos: ");
            Console.WriteLine("------------------------");

            for (int i = 0; i < productos.Length; i++)
            {
                // muestro los datos del producto
                Console.WriteLine($"Codigo: {productos[i].codigo}");
                Console.WriteLine($"Nombre: {productos[i].nombre}");
                Console.WriteLine($"Precio: {productos[i].precio}");
                Console.WriteLine($"Categoria: {productos[i].categoria}");
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }

    public struct Producto
    {
        public int codigo;
        public string nombre;
        public double precio;
        public string categoria;
    }
}
