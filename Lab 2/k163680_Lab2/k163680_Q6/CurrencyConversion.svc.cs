using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace k163680_Q6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CurrencyConversion : ICurrencyConversion
    {
        private CurrencyConverter currencyConverter;
        public CurrencyConversion()
        {
            currencyConverter = new CurrencyConverter();
        }


        public CurrencyRate[] GetCurrencyRates()
        {
            return currencyConverter.getCurrencyRates();
        }

        public double GetCurrencyConversion(string sourceCurrency, double amount, string destinationCurrency)
        {
            return currencyConverter.convertCurrency(sourceCurrency, amount, destinationCurrency);
        }
    }
}
