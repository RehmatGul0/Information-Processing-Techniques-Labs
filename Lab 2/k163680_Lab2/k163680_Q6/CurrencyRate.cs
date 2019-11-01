using System.Runtime.Serialization;

namespace k163680_Q6
{
    [DataContract]
    public class CurrencyRate
    {
        [DataMember]
        public string currencyName;
        [DataMember]
        public double rateWrtDollar;

        public CurrencyRate(string currencyName, double rateWrtDollar)
        {
            this.currencyName = currencyName;
            this.rateWrtDollar = rateWrtDollar;
        }

    }
}