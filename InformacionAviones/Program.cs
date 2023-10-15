namespace InformacionAviones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Avion> aviones = new List<Avion>();
            while (true)
            {

                Console.WriteLine("\nMenú de información de los aviones");
                Console.WriteLine("1. Agregar avión");
                Console.WriteLine("2. Ver los aviones guardados en el sistema");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nEscoge una de las opciones");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Console.WriteLine("Ingrese el módelo del avión: ");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Ingrese la cantidad de pasajeros del avión: ");
                    int pasajeros = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la velocidad máxima del avión: ");
                    string velocidaFinal = Console.ReadLine();

                    if (!string.IsNullOrEmpty(modelo) && !string.IsNullOrEmpty(velocidaFinal) && pasajeros != 0)
                    {
                        Avion nuevoAvion = new Avion();
                        nuevoAvion = nuevoAvion.CrearAvion(modelo, pasajeros, velocidaFinal);
                        aviones.Add(nuevoAvion);
                        Console.WriteLine("Se ingresó la información del avión correctamente" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nLa información es invalida");
                    }
                }

                if(respuesta == "2"){
                    if(aviones.Count > 0){
                        Console.WriteLine("\nLa información de los aviones que hay en el sistema es:");
                        MostrarInformacionAviones(aviones);
                    } else {
                        Console.WriteLine("No hay información para mostrar.");
                    }
                }

                if(respuesta == "3")
                    break;
            }
        }

        static void MostrarInformacionAviones(List<Avion> aviones)
        {
            foreach (Avion itemAvion in aviones)
            {
                Console.WriteLine($"\nEl modelo del avion es: {itemAvion.Modelo}\n"
                    + $"La capacidad de pasajeros del avión es: {itemAvion.CapacidadPasajeros}\n"
                    + $"La velocidad máxima del avión es: {itemAvion.VelocidadMaxima}\n"
                );
            }
        }
    }
}