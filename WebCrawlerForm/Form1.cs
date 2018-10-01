using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net.Http;
using ScrapySharp.Extensions;
using ScrapySharp;

namespace WebCrawlerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNBC_Click(object sender, EventArgs e)
        {
            GetNbcNews();
            
        }
        private void AddNews(List<Article> NewNews)
        {
            GrdAllArticles.DataSource = NewNews;
            
        }
        static async Task GetNbcNews()
        {
            var url = "https://www.nbcnews.com/politics";
            var client = new HttpClient();
            var html = await client.GetStringAsync(url);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var newsspans = doc.DocumentNode.CssSelect("span.headline___38PFH");

            var newsList = new List<Article>();
            foreach (var span in newsspans)
            {
                var article = new Article
                {

                    //Img = div.ParentNode..FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value,
                    Title = span.InnerText,
                    Source = "NBC News",
                    Category = "Politics",
                    Img = span.ParentNode.ParentNode.ParentNode.ParentNode.ChildNodes.CssSelect("picture").CssSelect("source").FirstOrDefault().Attributes.Where(x => x.Name == "srcset").FirstOrDefault().Value,
                    Link = span.ParentNode.Attributes.Where(x => x.Name == "href").FirstOrDefault().Value
                };
                newsList.Add(article);
            }
            
        }

 
    }
}
