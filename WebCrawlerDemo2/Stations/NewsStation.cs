using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net.Http;
using ScrapySharp.Extensions;
using ScrapySharp;

namespace WebCrawlerDemo2
{
    public class NewsStation
    {
        public List<Article> NewsList { get; set; } //end Articles
        public List<string> Htmlpage { get; set; } // All of the html pages
        public List<string> Urls { get; set; } // list of all urls to parse


        public async Task  GetHtml()
        {
            var client = new HttpClient();
            foreach(var url in Urls)
            {
               var html = await client.GetStringAsync(url);
                Htmlpage.Add(html);
            }
         
        }
    }

}
