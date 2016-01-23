using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuandlApiScraper.API
{
    internal class QuandlApiRequest
    {

        private const string REQUEST_FORMAT = @"{0}{1}_{2}.csv";

        public readonly string GeoCategory;
        public readonly string GeoCode;
        public readonly string VariableCode;
        public readonly string ApiKey;

        public const string REQUEST_URL = @"http://www.quandl.com/api/v3/datasets/ZILL/";

        public QuandlApiRequest(string geoCategory, string geoCode, string variableCode, string apiKey)
        {
            GeoCategory = geoCategory;
            GeoCode = geoCode;
            VariableCode = variableCode;
            ApiKey = apiKey;
        }



        public string GetRequestFullUrl()
        {
            return new StringBuilder().Append(REQUEST_URL)
             .Append(string.Format(REQUEST_FORMAT, GeoCategory, GeoCode, VariableCode))
             .Append(string.Format("?api_key={0}", ApiKey))
             .ToString();
        }
    }
}
