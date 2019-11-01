using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace k163680_Q4
{
    /// 
    [WebService(Namespace = "http://www.tempuri.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CurrencyConversion : System.Web.Services.WebService
    {
        private CurrencyConverter currencyConverter;
        public CurrencyConversion()
        {
            currencyConverter = new CurrencyConverter();
        }
  

        [WebMethod]
        public CurrencyRate[] GetCurrencyRates()
        {
            return currencyConverter.getCurrencyRates();
        }
        [WebMethod]
        public double GetCurrencyConversion(string sourceCurrency, double amount, string destinationCurrency)
        {
            return currencyConverter.convertCurrency(sourceCurrency, amount, destinationCurrency);
        }

    }
}
