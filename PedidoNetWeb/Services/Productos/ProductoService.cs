using PedidoNetWeb.Models.Productos;
using PedidoNetWeb.Services.Api;

namespace PedidoNetWeb.Services.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly ProductosApiClient _apiClient;
        public ProductoService(ProductosApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<List<ProductosDto>> GetAllAsync()
        {
            return _apiClient.GetAllSync();
        }
    }
}
