using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvert.Models
{
    public class ConversionResult
    {
        public double OriginalCurrency { get; set; }
        public double ConvertedCurrency { get; set; }
        public string ConversionPair { get; set; }
    }
}
