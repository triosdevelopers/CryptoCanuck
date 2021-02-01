using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CryptoCanuck.Models;

namespace CryptoCanuck.CryptoAPI
{
    public static class Fetch
    {
        public static HttpClient client = new HttpClient();
        public static string api_key_rui = "d2b3e6d1c2375491a5fdc1edb5d12d98f1d2e0d2b54a5ef2d90c673a9738ee6c";

        public static string dataLocal { get; set; }
  
        public static async Task GetCryptoPriceData()
        {
            ClearYourHead();

            //===========================>>
            // Get bitcoin historical price
            HttpResponseMessage cryptoData =
                await client.GetAsync("https://min-api.cryptocompare.com/data/v2/histoday?fsym=BTC&tsym=USD&limit=2000&api_key=" + api_key_rui);

            if (cryptoData.IsSuccessStatusCode)
            {
                dataLocal = await cryptoData.Content.ReadAsStringAsync();
                Program.price = JsonConvert.DeserializeObject<Crypto>(dataLocal);
                Program.dataScript = dataLocal;
            }
            else
            {
                dataLocal = null;
            }
        }

        public static async Task GetTop24HCryptoData(){
             ClearYourHead();
            //===========================>>
            // Get Top historical price
            HttpResponseMessage cryptoData =
                await client.GetAsync("https://min-api.cryptocompare.com/data/top/totalvolfull?limit=100&tsym=USD&api_key=" + api_key_rui);

            if (cryptoData.IsSuccessStatusCode)
            {
                dataLocal = await cryptoData.Content.ReadAsStringAsync();
                Program.topData = JsonConvert.DeserializeObject<Top24Root>(dataLocal);
            }
            else
            {
                dataLocal = null;
            }

        }
        private static void ClearYourHead()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(
                    "applicationException/json"));
        } // ClearYourHead()
    } // class
} // namespace