using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace k163680_Q6
{
    public class ConversionRates
    {
        Dictionary<string, CurrencyRate> _currencyRates;

        public ConversionRates()
        {
            _currencyRates = new Dictionary<string, CurrencyRate>()
            {
                { "AFN", new CurrencyRate("Afghani", 78.25) },
                { "AUD" , new CurrencyRate("Australian Dollar",1.46) },
                { "CAD" ,  new CurrencyRate("Canadian Dollar", 1.32) },
                { "EUR" , new CurrencyRate("Euro", 0.9) },
                { "JPY" , new CurrencyRate("Yen", 108.89) },
                { "PKR" , new CurrencyRate("Pakistan Rupee", 155.75) },
                { "QAR" , new CurrencyRate("Qatari Rial", 3.64) }

            };
        }

        public Dictionary<string, CurrencyRate> currencyRates
        {
            get { return this._currencyRates; }
        }
    }
}