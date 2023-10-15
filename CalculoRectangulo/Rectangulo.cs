namespace CalculoRectangulo
{
    public class Rectangulo
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public double CalcularArea(double ancho, double alto){
            return ancho * alto;
        }

        public double CalcularPerimetro(double ancho, double alto){
            return (2 * alto) + (2 * ancho);
        }
    }
}