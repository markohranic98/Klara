using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tecajnalista
{
    public class ExchangeRate
    {
        public string currencyName { get; set; }

        public double Rate { get; set; }

        public ExchangeRate(string currencyname, double rate)
        {
            currencyName = currencyname;
            Rate = rate;

        }
    }
}
