namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mascota> mascotas = new List<Mascota>();
            while (true)
            {

                Console.WriteLine("\nMenú de información de las mascotas");
                Console.WriteLine("1. Agregar mascota");
                Console.WriteLine("2. Ver la información de las mascotas en el sistema");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nEscoge una de las opciones");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Console.WriteLine("Ingrese el nombre de la mascota: ");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad de la mascota: ");
                    int edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el tipo de animal de la mascota: ");
                    string tipoAnimal = Console.ReadLine();

                    if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(tipoAnimal) && edad != 0)
                    {
                        Mascota nuevoMascota = new Mascota();
                        nuevoMascota = nuevoMascota.CrearMascota(nombre, edad, tipoAnimal);
                        mascotas.Add(nuevoMascota);
                        Console.WriteLine("\nSe ingresó la información de la mascota correctamente!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nLa información es invalida");
                    }
                }

                if(respuesta == "2"){
                    if(mascotas.Count > 0){
                        Console.WriteLine("\nLa información de las mascotas que hay en el sistema es:");
                        MostrarInformacionMascotas(mascotas);
                    } else {
                        Console.WriteLine("No hay información para mostrar.");
                    }
                }

                if(respuesta == "3")
                    break;
            }
        }

        static void MostrarInformacionMascotas(List<Mascota> mascotas)
        {
            foreach (Mascota itemMascota in mascotas)
            {
                Console.WriteLine($"\nEl nombre de la mascota es: {itemMascota.Nombre}\n"
                    + $"La edad de la mascota es: {itemMascota.Edad}\n"
                    + $"El tipo de animal de la mascota es: {itemMascota.TipoAnimal}\n"
                );
            }
        }
    }
}
