using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    public class sigurnosnaKontrola
    {
        public bool OtvoriVrata(int brKartice, int pin, int brVrata)
        {
            repozitorij pomoc = new repozitorij();
            korisnik Korisnik = pomoc.DohvatiKorisnika(brKartice, pin);
            vrata Vrata = pomoc.DohvatiVrata(brVrata);
            if (Vrata != null && Korisnik != null && Vrata.BrojVrata==Korisnik.RazinaPrava) return true;
            else return false;
        }
    }
}
