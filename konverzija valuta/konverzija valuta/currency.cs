using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konverzija_valuta
{
    public class currency
    {
        public string Name { get; set; }
        public double Tecaj { get; set; }

        public currency()
        {

        }
        public currency(string name, double tecaj)
        {
            Name = name;
            Tecaj = tecaj;
        }

        public double ConvertTo(double razlika, double iznos)
        {
            return iznos *  razlika;
        }
    }
}
