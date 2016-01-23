using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Net;

namespace QuandlApiScraper.API
{
    public class ZipCodeGatherer
    {
        private readonly ScraperConfig Config;

        public ZipCodeGatherer(ScraperConfig config)
        {
            Config = config;
        }

        public void GetDataForZipCode(string zipCode, IEnumerable<string> variableCodes)
        {
            foreach (var variableCode in variableCodes)
            {
                try
                {
                    var requestData = new QuandlApiRequest("Z", zipCode, variableCode, Config.ApiKey);
                    var requestUrl = requestData.GetRequestFullUrl();
                    var httpRequest = HttpWebRequest.CreateHttp(requestUrl);
                    var response = httpRequest.GetResponse();

                    var responseDataStream = response.GetResponseStream();
                    var reader = new StreamReader(responseDataStream);
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }                
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    
}