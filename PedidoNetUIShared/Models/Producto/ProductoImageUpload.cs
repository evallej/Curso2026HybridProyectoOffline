namespace PedidoNetUIShared.Models.Productos
{
    public class ProductoImageUpload
    {
        public required Stream Stream { get; init; }
        public required string FileName { get; init; }
        public required string ContentType { get; init; }
        public long Length { get; init; }
        public bool EsPrincipal { get; init; }
    }
}
