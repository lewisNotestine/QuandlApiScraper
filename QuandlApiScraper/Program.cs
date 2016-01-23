using QuandlApiScraper.API;
using QuandlApiScraper.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuandlApiScraper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (!args.Any() || args.Length > 1)
            { 
                Console.WriteLine("Usage : QuandlApiScraper <Your API KEY>");
                return; 
            }

            var config = new ScraperConfig(args[0]);

            var testZipGatherer = new ZipCodeGatherer(config);
            var testVariableCodes = new List<string>() 
            {
                VariableCode.A
            };

            testZipGatherer.GetDataForZipCode("97214", testVariableCodes); 
        }
    }
}
