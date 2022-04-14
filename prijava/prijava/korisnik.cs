using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijava
{
    public class korisnik
    {
        public int ID { get; set; }
        public string KorisnickoIme { get; set; }
        public korisnik(int id, string korisnickoime)
        {
            ID = id;
            KorisnickoIme = korisnickoime;
        }
    }
}
