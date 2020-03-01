using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvert.Algorithms
{
    public class ConversionAlgorithm
    {
        public double Convert(double ToConvert, string ConversionPair)
        {
            if(ConversionPair == "USDEUR")
            {
                return ToConvert * 0.91560;
            } else if(ConversionPair == "EURUSD")
            {
                return ToConvert * 1.09217;
            } else
            {
                return 0.0;
            }
        }
    }
}
