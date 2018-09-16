using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawlerDemo2
{
    class NBCNEWS : NewsStation
    {

        public async Task NBCNEWS()
        {
            var url = "https://www.nbcnews.com/politics";
            var client = new System.Net.Http.HttpClient();
            var html = await client.GetStringAsync(url);
        }
    }
}
