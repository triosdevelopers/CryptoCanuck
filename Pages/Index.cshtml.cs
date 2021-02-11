using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CryptoCanuck.CryptoAPI;
using CryptoCanuck.Models;

namespace CryptoCanuck.Pages
{
    public class IndexModel : PageModel
    {
        public List<PriceDatum> price = new List<PriceDatum>();
        
        // Top24 is the top coins with highest trading volume within last 24 hour
        public List<USD> top24Data = new List<USD>();
        public List<CoinInfo> top24CoinInfo = new List<CoinInfo>();
        public Prices prices = new Prices();

        public Prices totals = new Prices();
        public string symbol;
        public int amount;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {           
            await Fetch.GetTop24HCryptoData();
            foreach (Top24Datum top24 in Program.topData.Data)
            {
                if (top24.display != null){
                    top24Data.Add(top24.display.USD);
                    top24CoinInfo.Add(top24.CoinInfo);
                }               
            }
            
        } // OnGet() Created by Rui 

        public async Task OnPostPrices(string symbol, int amount)
        {
            await Fetch.GetPrices(symbol);
            prices = Program.prices;

            this.symbol = symbol;
            this.amount = amount;

            prices.CalcTotal(amount);

            await Fetch.GetTop24HCryptoData();
            foreach (Top24Datum top24 in Program.topData.Data)
            {
                if (top24.display != null){
                    top24Data.Add(top24.display.USD);
                    top24CoinInfo.Add(top24.CoinInfo);
                }               
            }
        } //OnPostPrices
    }
}
