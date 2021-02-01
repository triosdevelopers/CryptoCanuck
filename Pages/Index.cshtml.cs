using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CryptoCanuck.CryptoAPI;
using CryptoCanuck.Models;
using System.Timers;

namespace CryptoCanuck.Pages
{
    public class IndexModel : PageModel
    {
        public List<PriceDatum> price = new List<PriceDatum>();
        public List<USD> top24Data = new List<USD>();
        public List<CoinInfo> top24CoinInfo = new List<CoinInfo>();
        
        //Timer timer;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            /*
            aTimer = new Timer();
            aTimer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
            */
            
            await Fetch.GetTop24HCryptoData();
            foreach (Top24Datum top24 in Program.topData.Data)
            {
                top24Data.Add(top24.display.USD);
                top24CoinInfo.Add(top24.CoinInfo);
            }
            
        }

        /*
        private async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            await Fetch.GetTop24HCryptoData();
            foreach (Top24Datum top24 in Program.topData.Data)
            {
                top24Data.Add(top24.display.USD);
                top24CoinInfo.Add(top24.CoinInfo);
            }
        }
        */
    }
}
