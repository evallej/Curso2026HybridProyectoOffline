using PedidoNetWeb.Models.Productos;

namespace PedidoNetWeb.Services.Productos
{
    public interface IProductoService
    {
        Task<List<ProductosDto>> GetAllAsync();
    }
}
