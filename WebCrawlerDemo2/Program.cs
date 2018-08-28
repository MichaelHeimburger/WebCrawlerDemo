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

            GetNBCNewsPoliticsAsync();

            Console.ReadLine();



        }
       private static async Task GetNBCNewsPoliticsAsync()
        {
            var url = "https://www.nbcnews.com/politics";
            var client = new HttpClient();
            var html = await client.GetStringAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var newsdivs = doc.DocumentNode.Descendants("span").Where(x => x.Attributes["class"].Value == "headline___38PFH").ToList();
            var newsList = new List<Article>();
            foreach(var div in newsdivs)
            {
                var article = new Article
                {

                    //Img = div.ParentNode..FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
                    Title = div.InnerText,
                    //Date = div.Descendants("time").FirstOrDefault().InnerText,
                    //Img = div.ParentNode.ParentNode.ParentNode.ParentNode.ChildNodes.Where(x=>x.ChildNodes.Where(x=> x.ChildNodes.Where(x =>x.Attributes == "Picture") )))
                    Link = div.ParentNode.Attributes.Where(x =>x.Name=="href").FirstOrDefault().Value
                };
                newsList.Add(article);
            }




        }

    }
}
