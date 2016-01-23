
namespace QuandlApiScraper.BLL
{
    public class Variable
    {
        public readonly string VariableCode;
        public readonly string VariableValue;
        
        public Variable(string variableCode, string variableValue)
        {
            VariableCode = variableCode;
            VariableValue = variableValue;
        }
    }
}  