using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijava
{
    public class autentifikator
    {
        public autentifikator()
        {

        }
        public upraviteljlozinkama upravitelj = new upraviteljlozinkama();
        public bool PrijaviKorisnika(int idKorisnika, string lozinka)
        {
            if (upravitelj.DohvatiLozinku(idKorisnika) == lozinka) return true;
            else return false;
        }
    }
}
