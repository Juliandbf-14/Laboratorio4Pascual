namespace TiendaPelotas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelota> pelotas = new List<Pelota>();
            while (true)
            {

                Console.WriteLine("\nMenú de información de las pelotas");
                Console.WriteLine("1. Agregar pelota");
                Console.WriteLine("2. Ver la información de las pelotas en el sistema");
                Console.WriteLine("3. Salir");
                Console.WriteLine("\nEscoge una de las opciones");
                string respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Console.WriteLine("Ingrese el tipo de la pelota: ");
                    string tipoPelota = Console.ReadLine();

                    Console.WriteLine("Ingrese el diametro de la pelota: ");
                    string diametro = Console.ReadLine();

                    if (!string.IsNullOrEmpty(tipoPelota) && !string.IsNullOrEmpty(diametro))
                    {
                        Pelota nuevaPelota = new Pelota();
                        nuevaPelota = nuevaPelota.CrearPelota(tipoPelota, diametro);
                        pelotas.Add(nuevaPelota);
                        Console.WriteLine("\nSe ingresó la información de la pelota correctamente!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\nLa información es invalida");
                    }
                }

                if(respuesta == "2"){
                    if(pelotas.Count > 0){
                        Console.WriteLine("\nLa información de las pelotas que hay en el sistema es:");
                        MostrarInformacionPelotas(pelotas);
                    } else {
                        Console.WriteLine("No hay información para mostrar.");
                    }
                }

                if(respuesta == "3")
                    break;
            }
        }

        static void MostrarInformacionPelotas(List<Pelota> pelotas)
        {
            foreach (Pelota itemPelota in pelotas)
            {
                Console.WriteLine($"\nEl tipo de la pelota es: {itemPelota.TipoPelota}\n"
                    + $"El diametro de la pelota es: {itemPelota.Diametro}\n"
                );
            }
        }
    }
}