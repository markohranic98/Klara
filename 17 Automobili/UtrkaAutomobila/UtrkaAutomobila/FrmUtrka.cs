using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automobil;

namespace FrmUtrka
{
    public partial class FrmUtrka : Form
    {
        public static int broj = 0;
        public FrmUtrka()
        {
            InitializeComponent();
        }

        private void FrmUtrka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                dodaj();
            
           

        }

        public void dodaj()
        {
            
            ucAutomobil auto = new ucAutomobil();

            auto.Location = new Point(10, 10+broj);
            auto.Naziv = txtNaziv.Text;

            pnlAutomobili.Controls.Add(auto);
            broj += 90;
            
        }

        private void pnlAutomobili_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ucAutomobil uc = new ucAutomobil();
            foreach (var item in pnlAutomobili.Controls)
            {
                uc = (ucAutomobil)item;
                uc.Kreni();
            }
           
            
        }
    }
}
