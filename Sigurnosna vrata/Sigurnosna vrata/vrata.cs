using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigurnosna_vrata
{
    public class vrata
    {
        public int BrojVrata { get; set; }
        public int RazinaPrava { get; set; }
        public vrata(int razinaPrava, int brojVrata)
        {
            BrojVrata = brojVrata;
            RazinaPrava = razinaPrava;
        }
    }
}
