using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExternalAPI
{
    public static class Api
    {
        // External API with dummy user data

        // GET user data
        public static async Task<User> GetUser()
        {
            // connect the external API and return results
            try
            {

                User model = null;
                var client = new HttpClient();

                var task = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
                var jsonString = await task.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<User>(jsonString);
                return model;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
