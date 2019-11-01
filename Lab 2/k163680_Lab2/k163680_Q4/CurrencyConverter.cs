using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace k163680_Q4
{
    public class CurrencyConverter
    {
        private ConversionRates conversionRates;
 
       public CurrencyConverter()
        {
            conversionRates = new ConversionRates();
        }
        
        public CurrencyRate[] getCurrencyRates()
        {
            return this.conversionRates.currencyRates.Values.ToArray();
        }

        public double convertCurrency(string sourceCurrency , double amount , string destinationCurrency)
        {
            if (this.conversionRates.currencyRates.ContainsKey(sourceCurrency) && this.conversionRates.currencyRates.ContainsKey(destinationCurrency))
            {
                double usdValue = amount / this.conversionRates.currencyRates[sourceCurrency].rateWrtDollar;
                return usdValue * this.conversionRates.currencyRates[destinationCurrency].rateWrtDollar;
            }
            else
                return 0;
        }
    }
}