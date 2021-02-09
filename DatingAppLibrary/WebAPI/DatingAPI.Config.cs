using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;

namespace DatingAppLibrary.WebAPI
{
    public partial class DatingAPIConnection
    {
        private readonly HttpClient client = new HttpClient();
        public DatingAPIConnection()
        {
            client.BaseAddress = new Uri("http://localhost:63958/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
