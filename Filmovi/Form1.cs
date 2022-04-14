using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDohvatiFilmove_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            StreamingServis ss = new StreamingServis();
            List<Film> zapocetiFilmovi = ss.DohvatiZapoceteFilmove();
            PrikaziFilmove(zapocetiFilmovi);
        }

        private void PrikaziFilmove(List<Film> zapocetiFilmovi)
        {
            dataGridViewPopisFilmova.DataSource = null;
            dataGridViewPopisFilmova.DataSource = zapocetiFilmovi;
        }
    }
}
