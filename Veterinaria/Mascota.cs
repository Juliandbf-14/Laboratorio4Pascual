namespace Veterinaria
{
    public class Mascota
    {
        public string Nombre { get; set; } = string.Empty;

        public int Edad { get; set; }

        public string TipoAnimal { get; set; } = string.Empty;

        public Mascota CrearMascota(string nombre, int edad, string tipoAnimal){
            return new Mascota{
                Nombre = nombre,
                Edad = edad,
                TipoAnimal = tipoAnimal
            };
        }
    }
}