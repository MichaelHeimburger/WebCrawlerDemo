using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;

namespace WebCrawlerDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            GetEconomistAsync();

            Console.ReadLine();



        }
       private static async Task GetEconomistAsync()
        {
            var url = "https://www.economist.com/sites/default/files/";
            var client = new HttpClient();
            var html = await client.GetStringAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var newsdivs = doc.DocumentNode.Descendants("div").Where(x => x.Attributes["class"].Value == "section-teaser with-image").ToList();
            var newsList = new List<Article>();
            foreach(var div in newsdivs)
            {
                var article = new Article
                {
                    Img = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
                    Title = div.Descendants("h3").FirstOrDefault().InnerText,
                    Date = div.Descendants("time").FirstOrDefault().InnerText,
                    Source = div.Descendants("span").Where(x => x.Attributes["class"].Value == "source").Single().InnerText,
                    Preview = div.Descendants("p").Where(x => x.Attributes["class"].Value == "rubric-teaser").Single().InnerText,
                    Link = div.Attributes.Where(x=>x.Value=="href").Single().Value
                };
                newsList.Add(article);
            }




        }

    }
}
