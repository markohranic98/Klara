using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prijava
{
    public partial class Form1 : Form
    {
        public repozitorijkorisnika repozitorij = new repozitorijkorisnika();
        public autentifikator autentifikacija=new autentifikator();
        public upraviteljlozinkama lozinke = new upraviteljlozinkama();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprijava_Click(object sender, EventArgs e)
        {
            korisnik Korisnik = repozitorij.DohvatiKorisnika(txtkorime.Text);
            if (Korisnik != null)
            {
                if (autentifikacija.PrijaviKorisnika(Korisnik.ID, txtlozinka.Text) == true) MessageBox.Show("uspjesna prijava");
                else MessageBox.Show("korisnik postoji ali lozinka nije tocna");
            }
            else MessageBox.Show("Korisnik ne postoji!!");
        }
    }
}
