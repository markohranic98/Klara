using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib;

namespace tecajnalista
{
    public class Exchange
    {

        public List<ExchangeRate> GetExchangeRates()
        {
            List<string> popis= BankAPI.GetExchangeData();
            List<ExchangeRate> rezultat = new List<ExchangeRate>();
            foreach (var item in popis)
            {
                rezultat.Add(ExchangeParser.ParseRate(item));
            }
            return rezultat;
        }
    }
}
