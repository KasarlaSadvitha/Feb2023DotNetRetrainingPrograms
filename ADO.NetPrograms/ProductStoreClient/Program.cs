using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ProductStoreClient;

namespace ProductStoreClient
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64688/");

            //create a new product
            var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "widget" };
            Uri gizmoUri = null;

            HttpResponseMessage response = client.PostAsJsonAsync("api/MyProduct/PostProduct",gizmo).Result;
            if(response.IsSuccessStatusCode)
            {
                gizmoUri = response.Headers.Location;
                Console.WriteLine(gizmoUri);
            }
            else
            {
                Console.WriteLine("{0} {1}",(int)response.StatusCode,response.ReasonPhrase);
            }
            Console.WriteLine("-----------------");

            //Add an Accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));





            //Get a product by ID

            response = client.GetAsync("api/MyProduct/GetProductsById/2").Result;
            if (response.IsSuccessStatusCode)
            {
                //Parse the response body . Blocking
                var product = response.Content.ReadAsAsync<Product>().Result;
                Console.WriteLine("{0} \t{1}; \t{2}", product.Name, product.Price, product.Category);
            }
            else
            {
                Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("-----------------");



           // List all products
           response = client.GetAsync("api/MyProduct/GetProducts").Result;
            if (response.IsSuccessStatusCode)
            {
                //Parse the response body . Blocking
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var p in products)
                {
                    Console.WriteLine("{0} \t{1}; \t{2}", p.Name, p.Price, p.Category);
                }
            }
            else
            {
                Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("-----------------");




            //Update the newly added product
            gizmo.Price = 99.9;
        //    response = client.PutAsJsonAsync(gizmoUri.PathAndQuery, gizmo).Result;
        //    Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);

            Console.WriteLine("-----------------------------");




            ////Update any other product
            //Console.WriteLine("Enter product ID to Update :");
            //int id=int.Parse(Console.ReadLine());
            ////Retriving the Updatable Product to Update the price
            //response=client.GetAsync("api/MyProduct/PutProduct" +id).Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    //Parse the response body . Blocking
            //    var product = response.Content.ReadAsAsync<Product>().Result;
            //    product.Price = 110;
            //    response = client.PutAsJsonAsync("api/MyProduct/PutProduct" + id, product).Result;

            //    Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);

            //}
            //else
            //{
            //    Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);
            //}
            //Console.WriteLine("-----------------");
        }
    }
}
