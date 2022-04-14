using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmovi
{
    public class StreamingServis
    {
        public List<Film> DohvatiZapoceteFilmove()
        {
            KatalogFilmova kf = new KatalogFilmova();
            List<Film> sviFilmovi = kf.DohvatiSveFilmove();
            PovijestGledanja pg = new PovijestGledanja();
            List<PogledaniFilm> pogledaniFilmovi = pg.DohvatiPogledaneFilmove();
            List<Film> zapocetiFilmovi = new List<Film>();
            foreach (Film item in sviFilmovi)
            {
                foreach (PogledaniFilm item2 in pogledaniFilmovi)
                {
                    if (item.ID == item2.IdFilma && item.Trajanje != item2.TrenutnaMinuta)
                        zapocetiFilmovi.Add(item);
                }
            }
            return zapocetiFilmovi;
        }
    }
}
