using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konverzija_valuta
{
    public partial class Form1 : Form
    {
        
        public currency valuta=new currency();
        public currencyfactory pomoc = new currencyfactory();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currency prvi = comboFirst.SelectedItem as currency;
            currency drugi = combosecond.SelectedItem as currency;
            currency firstback = pomoc.GetCurrency(prvi.Name);
            currency secondback = pomoc.GetCurrency(drugi.Name);
            double iznos = firstback.Tecaj / secondback.Tecaj;
            double unos = double.Parse(txtamount.Text);
            double rjesenje = valuta.ConvertTo(iznos, unos);
            txtrjesenje.Text = rjesenje.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboFirst.DataSource = pomoc.valute;
            comboFirst.ValueMember = null;
            comboFirst.DisplayMember = "Name";
            combosecond.DataSource = pomoc.valute2;
            combosecond.ValueMember = null;
            combosecond.DisplayMember = "Name";
        }
    }
}
