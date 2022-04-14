using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class KatalogFilmova
    {
        public List<Film> sviFilmovi;
        public KatalogFilmova()
        {
            sviFilmovi = new List<Film>();
            sviFilmovi.Add(new Film(1, "Batman", 90));
            sviFilmovi.Add(new Film(2, "Superman", 85));
            sviFilmovi.Add(new Film(3, "Spiderman", 98));
            sviFilmovi.Add(new Film(4, "Ironman", 110));
            sviFilmovi.Add(new Film(5, "Hulk", 115));
        }
        public List<Film> DohvatiSveFilmove()
        {
            return sviFilmovi;
        }
    }
}
