using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuandlApiScraper.BLL
{
    public class DatasetBuilder
    {     
        private Dictionary<DateTime, Dictionary<string, VariableSet>> _dr;
        private Dictionary<DateTime, Dictionary<string, VariableSet>> DataRows
        {
            get { return _dr ?? (_dr = new Dictionary<DateTime, Dictionary<string, VariableSet>>()); }
        }
          
        public void GetDataset()
        {
            
            
        }
        
        
    }
}