using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace k163680_Q4
{
    [Serializable]
    public class CurrencyRate
    {
        public string currencyName;
        public double rateWrtDollar;
        public string currencyCode;
        public CurrencyRate()
        {

        }
        public CurrencyRate(string currencyName, double rateWrtDollar, string currencyCode)
        {
            this.currencyName = currencyName;
            this.rateWrtDollar = rateWrtDollar;
            this.currencyCode = currencyCode;
        }
    }
}