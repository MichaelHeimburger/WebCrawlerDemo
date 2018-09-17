using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawlerDemo2
{
    class NBCNEWS : NewsStation
    {

        public async Task GetNews()
        {
            var nbcurls =new List<string>() { "https://www.nbcnews.com/politics", "https://www.nbcnews.com/science", "https://www.nbcnews.com/world" };
            Urls.AddRange(nbcurls);
            await GetHtml();
            
            
            
        }
      
    }
}
