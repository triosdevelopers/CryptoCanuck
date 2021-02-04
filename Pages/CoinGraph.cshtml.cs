using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CryptoCanuck.Pages
{
    public class CoinGraphModel : PageModel
    {
        public string javaScriptString = "";
        public string coinName ="";
        private readonly ILogger<CoinGraphModel> _logger;

        public CoinGraphModel(ILogger<CoinGraphModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string coin)
        {
            coinName = coin;
            javaScriptString = "https://min-api.cryptocompare.com/data/v2/histoday?fsym=" + coin + "&tsym=USD&limit=2000&api_key=d2b3e6d1c2375491a5fdc1edb5d12d98f1d2e0d2b54a5ef2d90c673a9738ee6c";
            javaScriptString = System.Web.HttpUtility.JavaScriptStringEncode(javaScriptString);
        }
    }
}
