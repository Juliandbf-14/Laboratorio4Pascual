namespace GenerarFactura
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Factura> facturas = new List<Factura>();
            List<ProductosComprados> productos = new List<ProductosComprados>();

            bool activador = true;
            while (activador)
            {

                Console.WriteLine("\nMenú de información de las facturas");
                Console.WriteLine("1. Agregar factura");
                Console.WriteLine("2. Ver la información de las facturas en el sistema");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nEscoge una de las opciones");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Console.WriteLine("Ingrese el numero de la factura: ");
                    string numeroFactura = Console.ReadLine();

                    Console.WriteLine("Ingrese la fecha de la factura: ");
                    string fechaFactura = Console.ReadLine();

                    string swIngresarProducto = "Y";

                    while (swIngresarProducto == "Y")
                    {
                        ProductosComprados producto = new ProductosComprados();

                        Console.WriteLine("Ingrese el nombre del producto: ");
                        string nombreProducto = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio del producto: ");
                        double valorProducto = double.Parse(Console.ReadLine());

                        producto = producto.CrearProductos(nombreProducto, valorProducto);

                        if (!string.IsNullOrEmpty(producto.NombreProducto) && producto.ValorProducto != 0)
                        {
                            productos.Add(producto);
                            Console.WriteLine("Quieres ingresar otro producto? (Y/N)");
                            swIngresarProducto = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("La información de los productos es invalida.");
                            Console.WriteLine("Quieres volver a ingresar otro producto? (Y/N).");
                            swIngresarProducto = Console.ReadLine();
                        }
                    }
                    
                    if (!string.IsNullOrEmpty(numeroFactura) && !string.IsNullOrEmpty(fechaFactura) && productos.Count > 0)
                    {
                        Factura nuevaFactura = new Factura();
                        nuevaFactura = nuevaFactura.CrearFactura(numeroFactura, fechaFactura, productos);
                        facturas.Add(nuevaFactura);
                        Console.WriteLine("\nSe ingresó la información de la factura correctamente!" + "\n");
                        productos.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\nLa información ingresada es invalida");
                    }
                }

                if (respuesta == "2")
                {
                    if (facturas.Count > 0)
                    {
                        Console.WriteLine("\nLa información de las facturas que hay en el sistema es:");
                        MostrarInformacionFacturas(facturas);
                    }
                    else
                    {
                        Console.WriteLine("No hay información para mostrar.");
                    }
                }

                if (respuesta == "3")
                {
                    activador = false;
                }
            }
        }

        static void MostrarInformacionFacturas(List<Factura> facturas)
        {
            double total = 0;
            foreach (Factura itemFactura in facturas)
            {
                Console.WriteLine($"\nEl número de la factura es: {itemFactura.NumeroFactura}\n"
                    + $"La fecha de la factura es: {itemFactura.Fecha}\n"
                    + $"La lista de productos de la factura es:\n");
                itemFactura.ProductosComprados.ForEach(x =>
                {
                    Console.WriteLine($"Nombre del producto: {x.NombreProducto}");
                    Console.WriteLine($"Precio del producto: {x.ValorProducto}");
                    total += x.ValorProducto;
                });
                Console.WriteLine($"\nEl total de los productos es: {total}");
                total = 0;
            }
        }
    }
}
