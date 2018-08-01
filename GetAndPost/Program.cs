using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GetAndPost
{
    class Program
    {
        static void Main(string[] args)
        {


            PostRequest("https://jsonplaceholder.typicode.com/users");

            //GetRequest("https://jsonplaceholder.typicode.com/users");



            Console.ReadLine();
            
        }

        static async void GetRequest(String url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                   
                    using (HttpContent content = response.Content)
                    {
                        Console.WriteLine(response.StatusCode.ToString());

                        String json = await content.ReadAsStringAsync();


                        List<User> users = JsonConvert.DeserializeObject<List<User>>(json);


                        foreach (var user in users)
                        {
                            Console.WriteLine(user.name);
                        }
                    }

                }
            }
        }

        static async void PostRequest(String url)
        {
            using (HttpClient client = new HttpClient())
            {

                // Create dictionary to send as parameter
                Dictionary<String, String> data = new Dictionary<String, String>()
                {
                    {"name", "Denieall"},
                    {"email", "Joenethen"}
                };

                // Convert dictionary to json
                var json = JsonConvert.SerializeObject(data, Formatting.Indented);

                // Create http content using the serialized json
                HttpContent parameter = new StringContent(json);

                // Creating a post request
                using (HttpResponseMessage response = await client.PostAsync(url, parameter))
                {

                    using (HttpContent content = response.Content)
                    {
                        Console.WriteLine(response.StatusCode.ToString());
                        Console.WriteLine("---------------------------------------------");

                        String postResult = await content.ReadAsStringAsync();

                        Console.WriteLine(postResult);

                        GetRequest("https://jsonplaceholder.typicode.com/users");
                    }

                }
            }
        }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }


}
