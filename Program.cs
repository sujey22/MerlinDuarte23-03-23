using MerlinDuarte23_03_23.DAO;
using MerlinDuarte23_03_23.Models;

CrudProductos CrudProductos = new CrudProductos();
Producto Prod = new Producto();

Console.WriteLine(@"Menú
Pulse el numero 1 para Insertar un nuevo Producto:
Pulse el numero 2 para Salir:");

var Menú = Convert.ToInt32(Console.ReadLine());

switch (Menú)
{
    case 1:
        bool bucle = true;
        while (bucle == true)
        {
            Console.WriteLine("Ingrese el nombre del producto: ");
            Prod.Nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese una descripción del producto: ");
            Prod.Descripción = Console.ReadLine();
            Console.WriteLine("\nIngrese el precio del producto: $");
            Prod.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nIngrese la cantidad de productos existentes");
            Prod.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProductos.AgregarProductos(Prod);


            Console.Write(@"
El Producto se ingreso correctamente

Pulsa 1 para seguir insertando Productos
Pulsa 2 para salir
: ");

            var Menú2 = Convert.ToInt32(Console.ReadLine());

            switch (Menú2)
            {
                case 1:
                    bucle = true;
                    break;

                case 2:
                    bucle = false;
                    break;

                default:
                    Console.Write("Ingrese una opción del menú");
                    break;
            }
        }
        break;
    case 2: 
        Console.WriteLine("Gracias por utilizar nuestro programa");
        break;

    default:
        Console.WriteLine("La opción no se encuentra disponible");
        break;
}