namespace PedidoNetMobile.Configuration
{
    public static class ApiConfiguration
    {
        public static string GetBaseUrl()
            {
#if ANDROID
return "https://localhost:7150/";
#elif WINDOWS
return "http://localhost:5122/";
#else
            throw new PlatformNotSupportedException("PedidoNet Mobile solamente soporta Android & Windows")
#endif
        }
    }
}
