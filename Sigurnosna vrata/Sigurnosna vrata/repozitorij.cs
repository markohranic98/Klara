using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    public class repozitorij
    {
        public static List<vrata> ListaVrata = new List<vrata>();
        public static List<korisnik> Korisnici = new List<korisnik>();

        public repozitorij()
        {
            Korisnici.Add(new korisnik(10001, 1234, 1));
            Korisnici.Add(new korisnik(10002, 0000, 2));
            Korisnici.Add(new korisnik(10003, 9999, 2));

            ListaVrata.Add(new vrata(501, 1));
            ListaVrata.Add(new vrata(502, 2));
            ListaVrata.Add(new vrata(503, 2));

            
        }
        public korisnik DohvatiKorisnika(int brojkartice, int pin)
        {
            
            foreach (var item in Korisnici)
            {
                if (item.BrojKartice == brojkartice && item.PIN == pin) return item;
            }
            return null;
        }
        public vrata DohvatiVrata(int brojVrata)
        {

            foreach (var item in ListaVrata)
            {
                if (item.BrojVrata == brojVrata) return item;
            }
            return null;
        }
    }
}
