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
    public partial class Form1 : Form
    {
        public List<Zadatak> listaZadataka = new List<Zadatak>();
        public Zadatak noviZadatak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dataGridViewPopisZadataka.DataSource = null;
            List<Zadatak> sortiranaLista = listaZadataka.OrderBy(x=>x.KrajnjiRok).ToList();
            dataGridViewPopisZadataka.DataSource = sortiranaLista;
            ObojajNazad(sortiranaLista);
            for (int i = 0; i < sortiranaLista.Count; i++)
            {
                TimeSpan ts = DateTime.Now - sortiranaLista[i].KrajnjiRok;
                if (ts.TotalDays <= 1)
                    dataGridViewPopisZadataka.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void ObojajNazad(List<Zadatak> sortiranaLista)
        {
            for (int i = 0; i < sortiranaLista.Count; i++)
            {
                dataGridViewPopisZadataka.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void ButtonDodajZadatak_Click(object sender, EventArgs e)
        {
            using (NoviZadatak noviZadatak = new NoviZadatak())
            {
                DialogResult rezultat = noviZadatak.ShowDialog();
                if(rezultat == DialogResult.OK)
                {
                    this.noviZadatak = noviZadatak.noviZadatak;
                    listaZadataka.Add(this.noviZadatak);
                    Osvjezi();
                }
            }
        }
    }
}
