using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Final_Project___Ben_Kelley
{
    public class JSONHelper : Helper
    {
        /// <summary>
        /// Creates the HttpClient for all methods
        /// </summary>
        static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// This JSON helper gets a random fact from the API
        /// </summary>
        /// <returns>Returns an object for the Numbers class</returns>
        public static async Task<Numbers> GetRandomFact()
        {
            Numbers myDeserializedClass = new Numbers();
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://numbersapi.com/random?json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Numbers>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }

        /// <summary>
        /// Gets a specific fact from the API
        /// </summary>
        /// <param name="id">The id is used to find the fact</param>
        /// <returns>Returns a Numbers object</returns>
        public static async Task<Numbers> GetSpecificFact(string id)
        {
            Numbers myDeserializedClass = new Numbers();

            try
            {
                HttpResponseMessage response = await client.GetAsync("http://numbersapi.com/" + id + "?json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Numbers>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return myDeserializedClass;
        }
    }
}
