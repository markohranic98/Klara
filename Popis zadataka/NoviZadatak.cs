using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popis_zadataka
{
    public partial class NoviZadatak : Form
    {
        public Zadatak noviZadatak = new Zadatak();
        public NoviZadatak()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            noviZadatak.Naziv = textBoxNazivZadatka.Text;
            noviZadatak.KrajnjiRok = dateTimePicker1.Value.ToLocalTime();
            DialogResult = DialogResult.OK;
        }
    }
}
