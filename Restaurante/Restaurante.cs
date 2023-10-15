using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante
{
    public class Restaurante
    {
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public List<Menu> Menu { get; set; } = new List<Menu>();

        public void MostrarMenu(List<Menu> menus)
        {
            foreach (Menu item in menus)
            {
                Console.WriteLine($"El plato es: {item.Nombre} y su precio es de: {item.Precio}");
            }
        }

        public void TomarPedido(Restaurante restaurante)
        {
            string respuesta;
            while (true)
            {
                Console.WriteLine("Ingrese el nombre plato que desea:");
                string nombrePlato = Console.ReadLine();
                Menu menuExiste = restaurante.Menu.Find(x => x.Nombre == nombrePlato);

                Console.WriteLine("A nombre de quien el pedido?");
                string nombreCliente = Console.ReadLine();

                if (menuExiste != null)
                {
                    Console.WriteLine("Quieres cambiar el pedido? (Y/N)");
                    respuesta = Console.ReadLine();
                    if(respuesta == "N"){
                        Console.WriteLine($"\nEl pedido de {nombreCliente} es {menuExiste.Nombre} y tiene un valor de {menuExiste.Precio}");
                        Console.WriteLine("El pedido ha sido exitoso!");
                        break;
                    } 
                }
                else
                {
                    Console.WriteLine("Ese plato no esta en el menú.");
                    Console.WriteLine("Quieres intentar pedir otro plato? (Y/N)");
                    respuesta = Console.ReadLine();
                    if(respuesta == "N")
                        break;
                }
            }
        }
    }

    public class Menu
    {
        public string Nombre { get; set; } = string.Empty;
        public double Precio { get; set; }

        public Menu AgregarPlato()
        {
            Console.WriteLine($"Ingresa el nombre del plato: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Ingresa el precio del plato: ");
            double precio = double.Parse(Console.ReadLine());
            return new Menu
            {
                Nombre = nombre,
                Precio = precio
            };
        }
    }
}
