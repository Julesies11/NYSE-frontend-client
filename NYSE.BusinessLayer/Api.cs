using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;

namespace NYSE.BusinessLayer
{
    public static class Api
    {
        // this class contains all the Api calls

        private const string URLBase = "http://localhost:8088/";


        // GET HelloWorld for testing purposes
        public static async Task<string> HelloWorld()
        {
            
            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("api/dailyprices/helloworld");

                // check the reponse code
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new ApplicationException("Error: " + response.StatusCode.ToString());
                }
            }

        }

        // GET all prices. pass in number of records to return
        public static async Task<IEnumerable<DailyPrice>> GetDailyPrices(int top)
        {
            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string URL = $"api/dailyprices?top={top}";

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(URL);

                // check the reponse code
                if (response.IsSuccessStatusCode)
                {
                    //IEnumerable<DailyPrice> priceList = await response.Content.ReadAsAsync<IEnumerable<DailyPrice>>();
                    return await response.Content.ReadAsAsync<IEnumerable<DailyPrice>>();
                }
                else
                {
                    throw new ApplicationException("Error: " + response.StatusCode.ToString());
                }

            }

        }

        // GET single price record by Id
        public static async Task<DailyPrice> GetDailyPrice(int id)
        {
            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string URL = $"api/dailyprices/{id}";

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(URL);

                // check the reponse code
                if (response.IsSuccessStatusCode)
                {
                    //List<DailyPrice> priceList = response.Content.ReadAsAsync<DailyPrice>();
                    return await response.Content.ReadAsAsync<DailyPrice>();
                }
                else
                {
                    throw new ApplicationException("Error: " + response.StatusCode.ToString());
                }

            }

        }

        // POST
        public static async Task<DailyPrice> PostDailyPrice(DailyPrice price)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // initialise the HttpClient
                    client.BaseAddress = new Uri(URLBase);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    // HTTP GET
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/dailyprices", price);

                    //return await response.Content.ReadAsAsync<DailyPrice>();

                    // check the reponse code
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsAsync<DailyPrice>();
                    }
                    else
                    {
                        throw new ApplicationException(response.StatusCode.ToString());
                    }
                }

            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ProtocolError)
            {
                //code specifically for a WebException ProtocolError
                throw new ApplicationException("Error: WebException ProtocolError");
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {
                //code specifically for a WebException NotFound
                throw new ApplicationException("Error: WebException NotFound");
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                //code specifically for a WebException InternalServerError
                throw new ApplicationException("Error: WebException InternalServerError");
            }

        }

        // PUT
        public static async Task<DailyPrice> UpdateDailyPrice(DailyPrice price)
        {

            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP PUT
                HttpResponseMessage response = await client.PutAsJsonAsync($"api/dailyprices/{price.Id}", price);

                //return await response.Content.ReadAsAsync<DailyPrice>();

                // check the reponse code
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the updated price data from the response body
                    return await response.Content.ReadAsAsync<DailyPrice>();
                }
                else
                {
                    throw new ApplicationException(response.StatusCode.ToString());
                }
            }

        }

        // DELETE id
        public static async Task<DailyPrice> DeleteDailyPrice(int id)
        {

            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP DELETE
                HttpResponseMessage response = await client.DeleteAsync($"api/dailyprices/{id}");

                // check the reponse code
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize the updated price data from the response body
                    return await response.Content.ReadAsAsync<DailyPrice>();
                }
                else
                {
                    throw new ApplicationException(response.StatusCode.ToString());
                }
            }

        }

        // DELETE symbol
        public static async Task<HttpStatusCode> DeleteDailyPrices(string stock_symbol)
        {

            using (var client = new HttpClient())
            {
                // initialise the HttpClient
                client.BaseAddress = new Uri(URLBase);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP DELETE
                HttpResponseMessage response = await client.DeleteAsync($"api/dailyprices/symbol/{stock_symbol}");

                // return status
                return response.StatusCode;

            }

        }
    }
}
