
namespace TiendaPelotas
{
    public class Pelota
    {
        public string TipoPelota { get; set; } = string.Empty;
        public string Diametro { get; set; } = string.Empty;

        public Pelota CrearPelota(string tipoPelota, string diametro){
            return new Pelota{
                TipoPelota = tipoPelota,
                Diametro = diametro
            };
        }
    }
}