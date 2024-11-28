using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaro la variable producto de tipo Producto
            Producto producto;

            // cargo los campos
            Console.WriteLine("Ingrese el codigo del producto: ");
            producto.codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del producto: ");
            producto.nombre = Console.ReadLine();

            Console.WriteLine("Ingree el precio del producto: ");
            producto.precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la categoria del producto: ");
            producto.categoria = Console.ReadLine();

            // muestro los datos del producto
            Console.WriteLine("Datos del Producto\n");
            Console.WriteLine($"Codigo: {producto.codigo}");
            Console.WriteLine($"Nombre: {producto.nombre}");
            Console.WriteLine($"Precio: {producto.precio}");
            Console.WriteLine($"Categoria: {producto.categoria}");

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


/*
 
Crear una estructura para almacenar los datos
pertenecientes a los productos de una tienda.
Los datos a registrar para un producto son:
    - Código.
    - Nombre.
    - Precio.
    - Categoría.

Codificar una aplicación de consola que permita
cargar todos los datos de un producto y
mostrarlos por pantalla.
 
 
 */
