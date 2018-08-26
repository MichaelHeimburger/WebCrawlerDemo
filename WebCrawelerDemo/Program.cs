using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
namespace WebCrawelerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCrawlerAsync();
            Console.ReadLine();

        }
        private static async Task StartCrawlerAsync()
        {
            var url = "https://www.automobile.tn/neuf/bmw.3/";
            var httpClient = new HttpClient(); //New Instance of HTML Class
            var html = await httpClient.GetStringAsync(url); // Sends a Get Request ot the url and returns the result as an html document
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html); // load the html document recieved
            var divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("article_new_car article_last_modele")).ToList();

            var cars = new List<Car>();
            foreach (var div in divs)
            {
                var car = new Car
                {
                    Model = div.Descendants("h2").FirstOrDefault().InnerText,
                    Price = div.Descendants("div").FirstOrDefault().InnerText,
                    Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value,
                    ImageUrl = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value
                };
                cars.Add(car);
            }
        }
        
    }
}
