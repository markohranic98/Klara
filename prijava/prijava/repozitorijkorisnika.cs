using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijava
{
    public class repozitorijkorisnika
    {
        public List<korisnik> korisnici = new List<korisnik>();

        public repozitorijkorisnika()
        {
            korisnici.Add(new korisnik(1, "pperic"));
            korisnici.Add(new korisnik(2, "ihorvat"));
        }

        public korisnik DohvatiKorisnika(string korime)
        {
            foreach (var item in korisnici)
            {
                if (item.KorisnickoIme == korime) return item;
            }
            return null;
        }
    }
}
