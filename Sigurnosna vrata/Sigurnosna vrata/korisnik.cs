using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    public class korisnik
    {
        public int BrojKartice { get; set; }
        public int PIN { get; set; }
        public int RazinaPrava { get; set; }

        public korisnik(int brojKartice, int pin, int razinaPrava)
        {
            BrojKartice = brojKartice;
            PIN = pin;
            RazinaPrava = razinaPrava;
        }
    }
}
