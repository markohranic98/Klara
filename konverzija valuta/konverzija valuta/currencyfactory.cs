using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konverzija_valuta
{
    public class currencyfactory
    {
        public List<currency> valute = new List<currency>();
        public List<currency> valute2 = new List<currency>();
        public currencyfactory()
        {
            valute.Add(new currency("HRK", 1));
            valute.Add(new currency("EUR", 7.4));
            valute.Add(new currency("USD", 6.5));
            valute.Add(new currency("GBP", 8.5));
            valute.Add(new currency("CAD", 4.9));
            valute2.Add(new currency("HRK", 1));
            valute2.Add(new currency("EUR", 7.4));
            valute2.Add(new currency("USD", 6.5));
            valute2.Add(new currency("GBP", 8.5));
            valute2.Add(new currency("CAD", 4.9));
        }

        public currency GetCurrency(string name)
        {
            foreach (var item in valute)
            {
                if (item.Name == name) return item;
                
            }
            return null;
        }

        
       
    }
}
