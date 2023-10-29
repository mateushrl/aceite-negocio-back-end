using Microsoft.OpenApi.Models;

namespace AceiteNegocio.Util
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}