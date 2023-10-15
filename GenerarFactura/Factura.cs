namespace GenerarFactura
{
    public class Factura
    {
        public string NumeroFactura { get; set; } = string.Empty;
        public string Fecha { get; set; } = string.Empty;
        public List<ProductosComprados> ProductosComprados { get; set; } = new List<ProductosComprados>();
        public Factura CrearFactura(string numeroFactura, string fecha, List<ProductosComprados> productosComprados){
            return new Factura{
                NumeroFactura =  numeroFactura,
                Fecha = fecha,
                ProductosComprados = new List<ProductosComprados>(productosComprados)
            };
        }
    }

    public class ProductosComprados
    {
        public string NombreProducto { get; set; } = string.Empty;
        public double ValorProducto { get; set; } 

        public ProductosComprados CrearProductos(string nombreProducto, double valorProducto){
            return new ProductosComprados{
                NombreProducto = nombreProducto,
                ValorProducto = valorProducto
            };
        }
    }
}