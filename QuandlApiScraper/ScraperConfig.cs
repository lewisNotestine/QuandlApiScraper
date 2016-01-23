using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuandlApiScraper
{
    public class ScraperConfig
    {
        public readonly string ApiKey;

        public ScraperConfig(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
