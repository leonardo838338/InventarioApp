using System;

namespace InventarioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Pedimos los datos al usuario
            Console.Write("Escribe el nombre del producto: ");
            string producto = Console.ReadLine();

            Console.Write("Escribe la cantidad: ");
            string entradaCantidad = Console.ReadLine();
            int cantidad = int.Parse(entradaCantidad);

            Console.Write("Escribe el precio: ");
            string entradaPrecio = Console.ReadLine();
            double precio = double.Parse(entradaPrecio);

            // 2. Hacemos el cálculo
            double totalInventario = cantidad * precio;

            // 3. Mostramos el resultado
            Console.WriteLine("\n--- Resumen del Inventario ---");
            Console.WriteLine($"Producto registrado: {producto}");
            Console.WriteLine($"Total en inventario: ${totalInventario}");
        }
    }
}