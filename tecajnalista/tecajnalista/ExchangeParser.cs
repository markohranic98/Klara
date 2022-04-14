using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tecajnalista
{
    public static class ExchangeParser
    {
        public static ExchangeRate ParseRate(string item)
        {
            
            string[] podjeljeno = item.Split(';');
            ExchangeRate nova = new ExchangeRate(podjeljeno[0], double.Parse(podjeljeno[1]));
            return nova;
        }
    }
}
