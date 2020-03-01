using Microsoft.AspNetCore.Mvc;
using CurrencyConvert.Models;
using CurrencyConvert.Algorithms;
using CurrencyConvert.Mappers;

namespace CurrencyConvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertController : ControllerBase
    {
        [HttpGet("USD/EUR/{amount}")]
        public ActionResult<ConversionResult> ConvertUSDEUR(double amount)
        {
            double ConvertedAmount = new ConversionAlgorithm().Convert(amount, "USDEUR");
            return Ok(Mapper.Map(amount, ConvertedAmount, "USDEUR"));
        }
        [HttpGet("EUR/USD/{amount}")]
        public ActionResult<ConversionResult> ConvertEURUSD(double amount)
        {
            double ConvertedAmount = new ConversionAlgorithm().Convert(amount, "EURUSD");
            return Ok(Mapper.Map(amount, ConvertedAmount, "EURUSD"));
        }
    }
}
