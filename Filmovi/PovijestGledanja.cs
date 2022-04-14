using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class PovijestGledanja
    {
        private List<PogledaniFilm> pogledaniFilmovi;
        public PovijestGledanja()
        {
            pogledaniFilmovi = new List<PogledaniFilm>();
            pogledaniFilmovi.Add(new PogledaniFilm(1, 90));
            pogledaniFilmovi.Add(new PogledaniFilm(2, 70));
            pogledaniFilmovi.Add(new PogledaniFilm(5, 55));
        }
        public List<PogledaniFilm> DohvatiPogledaneFilmove()
        {
            return pogledaniFilmovi;
        }
    }
}
