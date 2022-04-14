﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Popis_zadataka
{
    public class Zadatak
    {
        public string Naziv { get; set; }
        public DateTime KrajnjiRok { get; set; }
        public Zadatak(string naziv, DateTime krajnjiRok)
        {
            Naziv = naziv;
            KrajnjiRok = krajnjiRok;
        }
        public Zadatak()
        {

        }
    }
}
