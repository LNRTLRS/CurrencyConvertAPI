using CurrencyConvert.Models;

namespace CurrencyConvert.Mappers
{
    public class Mapper
    {
        public static ConversionResult Map(double oc, double cc, string cp)
        {
            ConversionResult result = new ConversionResult
            {
                OriginalCurrency = oc,
                ConvertedCurrency = cc,
                ConversionPair = cp
            };
            return result;
        }
    }
}
