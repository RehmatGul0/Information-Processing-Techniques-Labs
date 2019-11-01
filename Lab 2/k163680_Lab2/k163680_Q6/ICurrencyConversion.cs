using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace k163680_Q6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICurrencyConversion
    {

        [OperationContract]
        CurrencyRate[] GetCurrencyRates();

        [OperationContract]
        double GetCurrencyConversion(string sourceCurrency, double amount, string destinationCurrency);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    
 
}
