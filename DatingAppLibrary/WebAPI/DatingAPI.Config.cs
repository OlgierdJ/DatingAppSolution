using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DatingAppLibrary.WebAPI
{
    public partial class DatingAPIConnection
    {
        private readonly HttpClient client = new HttpClient();
        public JsonSerializerOptions SerializerOptions { get; set; } = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, ReferenceHandler = ReferenceHandler.Preserve };
        public DatingAPIConnection()
        {
            client.BaseAddress = new Uri("http://localhost:63958/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
