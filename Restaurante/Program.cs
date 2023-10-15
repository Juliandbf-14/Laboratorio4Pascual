namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante
            {
                Nombre = "Delicias Jardin",
                Direccion = "Calle 80 "
            };

            while (true)
            {
                Console.WriteLine($"\nMenú de Opciones del Restaurante {restaurante.Nombre}");
                Console.WriteLine("1. Agregar plato al menú del restaurante");
                Console.WriteLine("2. Mostrar Menú y tomar pedido");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nEscoge una opción:");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Menu nuevoPlato = new Menu();
                    nuevoPlato = nuevoPlato.AgregarPlato();

                    if (!string.IsNullOrEmpty(nuevoPlato.Nombre) && nuevoPlato.Precio != 0)
                    {
                        restaurante.Menu.Add(nuevoPlato);
                        Console.WriteLine("\nSe agregó el nuevo plato de forma exitosa!");
                    }
                    else
                    {
                        Console.WriteLine($"\nNo se pudo agregar el nuevo plato a la carta del restaurante");
                    }
                }

                if (respuesta == "2")
                {

                    Console.WriteLine($"\nSomos el restaurante {restaurante.Nombre}\n");

                    if (restaurante.Menu.Count > 0)
                    {
                        Console.WriteLine("Tenemos los siguientes platos en nuestro menú:\n");
                        restaurante.MostrarMenu(restaurante.Menu);
                        Console.WriteLine();

                        Console.WriteLine("Quiere que le tomemos su pedido? (Y/N)");
                        string decision = Console.ReadLine();
                        if (decision == "Y")
                        {
                            restaurante.TomarPedido(restaurante);
                            Console.WriteLine($"Gracias por pedir en el restaurante {restaurante.Nombre}");
                        }
                    } else {
                        Console.WriteLine("No hay servicio en estos momentos");
                    }
                }

                if (respuesta == "3")
                {
                    break;
                }
            }
        }
    }
}