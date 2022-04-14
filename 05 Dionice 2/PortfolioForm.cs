using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Dionice_2
{
    public partial class PortfolioForm : Form
    {
        public PortfolioForm()
        {
            InitializeComponent();
        }

        private void buttonPortfolio_Click(object sender, EventArgs e)
        {
            StockPortfolio sp = new StockPortfolio();
            List<Stock> stocks = sp.GetMyStocks();
            DisplayData(stocks);
        }

        private void DisplayData(List<Stock> stocks)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = stocks;
            double total = 0;
            foreach (Stock item in stocks)
            {
                total += item.Worth;
            }
            textBoxTotal.Text = total.ToString();
        }
    }
}
