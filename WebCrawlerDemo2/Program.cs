using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using ScrapySharp.Extensions;
using ScrapySharp;
using System.Threading;
using ScrapySharp.Network;

namespace WebCrawlerDemo2
{

    class Program
    {

        static void Main(string[] args)
        {
            var task = GetNBCNewsPolitcsAsync();
            //task.Wait();
            //var x = task.Result;
            //foreach(Article article in x)
            //{
            //    Console.WriteLine(article.Title);
            //}
            Console.ReadLine();
        }
       

        public static async Task/*<List<Article>>*/ GetNBCNewsPolitcsAsync()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.nbcnews.com/");
            var webList = doc.DocumentNode.CssSelect("div.subsectionTwoColumn___2iH8u").CssSelect("subsectionListItemLarge___3RSqG");
            
            foreach(var li in webList)
            {
                Console.WriteLine(li.CssSelect("a").FirstOrDefault().Attributes.Where(x => x.Name == "srcset").FirstOrDefault().Value);
            }
            












            




            ////var url = "https://www.nbcnews.com/politics";
            //var client = new HttpClient();
            ////var html = await client.GetStringAsync(url);
            //var html = await client.GetStringAsync("https://www.nbcnews.com/");
            //var doc = new HtmlDocument();
            //var siteMap = doc.DocumentNode.CssSelect("subsectionListItemLarge___3RSqG");
            //var siteMapLinks = siteM
            ////var nbcurls = new List<string>() { "https://www.nbcnews.com/politics", "https://www.nbcnews.com/science", "https://www.nbcnews.com/world", "https://www.nbcnews.com/culture-matters","https://www.nbcnews.com/in-focus" };
            ////var htmlz = new List<string>();
            //var newsList = new List<Article>();
            ////foreach (var url in nbcurls)
            ////{
            ////    var html = await client.GetStringAsync(url);
            ////    htmlz.Add(html);
            ////    var doc = new HtmlDocument();
            ////    doc.LoadHtml(html);
            ////    var newsspans = doc.DocumentNode.CssSelect("span.headline___38PFH");
            ////    foreach (var span in newsspans)
            ////    {
            ////        var article = new Article
            ////        {

            ////            //Img = div.ParentNode..FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
            ////            Title = span.InnerText,
            ////            Source = "NBC News",
            ////            Category = "Politics",
            ////            Img = span.ParentNode.ParentNode.ParentNode.ParentNode.ChildNodes.CssSelect("picture").CssSelect("source").FirstOrDefault().Attributes.Where(x => x.Name == "srcset").FirstOrDefault().Value,
            ////            Link = span.ParentNode.Attributes.Where(x => x.Name == "href").FirstOrDefault().Value
            ////        };
            ////        newsList.Add(article);
            ////    }

            ////}
            //return newsList;
        }
    }
}

