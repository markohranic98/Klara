using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigurnosna_vrata
{
    public partial class otvaranjevrata : Form
    {
        public otvaranjevrata()
        {
            InitializeComponent();
        }

        sigurnosnaKontrola kontorla = new sigurnosnaKontrola();

        private void btn501_Click(object sender, EventArgs e)
        {

            if (kontorla.OtvoriVrata(int.Parse(txtBrojKartice.Text), int.Parse(txtpin.Text), 1)==true) MessageBox.Show("Vrata uspjesno otvorena!!");
            else MessageBox.Show("Vrata nisu otvorena!!");
        }

        private void btn502_Click(object sender, EventArgs e)
        {
            if (kontorla.OtvoriVrata(int.Parse(txtBrojKartice.Text), int.Parse(txtpin.Text), 2)==true) MessageBox.Show("Vrata uspjesno otvorena!!");
            else MessageBox.Show("Vrata nisu otvorena!!");
        }

        private void btn503_Click(object sender, EventArgs e)
        {
            if (kontorla.OtvoriVrata(int.Parse(txtBrojKartice.Text), int.Parse(txtpin.Text), 2)==true) MessageBox.Show("Vrata uspjesno otvorena!!");
            else MessageBox.Show("Vrata nisu otvorena!!");
        }
    }
}
