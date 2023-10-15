namespace CalculoRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nCalculos del Rectangulo");
                Console.WriteLine("1. Calcular area del Rectangulo");
                Console.WriteLine("2. Calcular perimetro del Rectangulo");
                Console.WriteLine("3. Salir");

                Console.WriteLine("\nSelecciona una opción");
                int respuesta = int.Parse(Console.ReadLine());

                if(respuesta == 1){
                    Rectangulo objRectangulo = new Rectangulo();
                    Console.WriteLine("Ingrese el ancho del rectangulo");
                    double ancho = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el alto del rectangulo");
                    double alto = double.Parse(Console.ReadLine());

                    double resultado = objRectangulo.CalcularArea(ancho, alto);
                    Console.WriteLine($"El area del rectangulo con un ancho de {ancho} y alto {alto} es: {resultado}");
                }

                if(respuesta == 2){
                    Rectangulo objRectangulo = new Rectangulo();
                    Console.WriteLine("Ingrese el ancho del rectangulo");
                    double ancho = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el alto del rectangulo");
                    double alto = double.Parse(Console.ReadLine());

                    double resultado = objRectangulo.CalcularPerimetro(ancho, alto);
                    Console.WriteLine($"El perímetro del rectangulo con un ancho de {ancho} y alto {alto} es: {resultado}");
                }

                if(respuesta == 3){
                    break;
                }

                Console.WriteLine("¿Quieres hacer otro cálculo? (Y/N)");
                string reinicio = Console.ReadLine();

                if(reinicio == "N")
                    break;
            }
        }
    }
}
