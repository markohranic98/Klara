using StocksLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Dionice_2
{
    public class StockPortfolio
    {
        public List<Stock> GetMyStocks()
        {
            List<string> ownedStocksData = StockExchangeAPI.GetOwnedStocksData();
            double cijenaDionica;
            List<Stock> stocks = new List<Stock>();
            foreach (string item in ownedStocksData)
            {
                string[] itemData = item.Split(';');
                cijenaDionica = StockExchangeAPI.GetStockPrice(itemData[0]);
                stocks.Add(new Stock(itemData[0], double.Parse(itemData[1]), cijenaDionica));
            }
            return stocks;
        }
    }
}
