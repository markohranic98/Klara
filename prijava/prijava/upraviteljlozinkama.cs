using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prijava
{
    public class upraviteljlozinkama
    {
        public List<string> lozinke = new List<string>();
        public upraviteljlozinkama()
        {
            lozinke.Add("1;abc111");
            lozinke.Add("2;abc222");
        }

        public string DohvatiLozinku(int idKorisnika)
        {
            foreach (var item in lozinke)
            {
                if (int.Parse(item.Substring(0, 1)) == idKorisnika)
                {
                    return item.Substring(2, 6);
                }
            }
            return null;
        }
    }
}
