namespace InformacionAviones
{
    public class Avion
    {
        public string Modelo { get; set; } = string.Empty;
        public int CapacidadPasajeros { get; set; }
        public string VelocidadMaxima { get; set; } = string.Empty;

        public Avion CrearAvion(string modelo, int capacidad, string velocidaFinal){
            return new Avion{
                Modelo = modelo,
                CapacidadPasajeros = capacidad,
                VelocidadMaxima = velocidaFinal
            };
        }

        
    }
}