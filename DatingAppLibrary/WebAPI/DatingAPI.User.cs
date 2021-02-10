using DatingAppLibrary.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
//using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.Json;

namespace DatingAppLibrary.WebAPI
{
    public partial class DatingAPIConnection
    {
        public async Task<Uri> CreateUserAsync(User user)
        {
            var load = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(load, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("user/CreateUser", content);
            response.EnsureSuccessStatusCode();
            return response.Headers.Location;
        }

        public async Task<User> Login(string username, string password)
        {
            User user = new User()
            {
                Username = username, 
                Password = password 
            };
            var load = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(load, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("user/login", content);
            //response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<User>(await response.Content.ReadAsStringAsync(), SerializerOptions);
            }
            return null;
        }

        public async Task<User> GetUserAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync(
                $"user/{id}");
            //response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<User>(await response.Content.ReadAsStringAsync(), SerializerOptions);
            }
            return null;
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            var load = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(load, Encoding.UTF8);
            HttpResponseMessage response = await client.PutAsync($"user/{user.ID}", content);
            response.EnsureSuccessStatusCode();
            user = JsonSerializer.Deserialize<User>(await response.Content.ReadAsStringAsync(), SerializerOptions);
            return user;
        }
        public async Task<HttpStatusCode> DeleteUserAsync(User user)
        {
            HttpResponseMessage response = await client.DeleteAsync($"user/{user.ID}");
            return response.StatusCode;
        }

    }
}
