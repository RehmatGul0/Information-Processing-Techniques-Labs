using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace k163680_Q4
{
    public class ConversionRates
    {
        Dictionary<string, CurrencyRate> _currencyRates;

        public ConversionRates()
        {
            _currencyRates = new Dictionary<string, CurrencyRate>()
            {
                { "AFN", new CurrencyRate("Afghani", 78.25,"AFN") },
                { "AUD" , new CurrencyRate("Australian Dollar",1.46,"AUD") },
                { "CAD" ,  new CurrencyRate("Canadian Dollar", 1.32,"CAD") },
                { "EUR" , new CurrencyRate("Euro", 0.9,"EUR") },
                { "JPY" , new CurrencyRate("Yen", 108.89,"JPY") },
                { "PKR" , new CurrencyRate("Pakistan Rupee", 155.75,"PKR") },
                { "QAR" , new CurrencyRate("Qatari Rial", 3.64,"QAR") }

            };
        }

        public Dictionary<string, CurrencyRate> currencyRates
        {
            get { return this._currencyRates; }
        }
    }
}