using PedidoNetWeb.Models;
using PedidoNetWeb.Models.Auth;
using System.Net.Http.Json;

namespace PedidoNetWeb.Services.Api
{
    public class AuthApiClient
    {
        private readonly HttpClient _httpClient;
        public AuthApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResponse<LoginResponse>?>LoginAsync(LoginRequest request)
        {
            var httpResponse = await _httpClient.PostAsJsonAsync("api/v1/Auth/login", request);
            var response= await httpResponse.Content.ReadFromJsonAsync<ApiResponse<LoginResponse>>();

            return response;
        }
    }
}
