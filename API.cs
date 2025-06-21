using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class API
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string apiKey = File.ReadAllText("apikey.txt").Trim();

        public static async Task<string?> GetExchangeRateAsync(string baseCurrency, string targetCurrency, decimal amountToConvert)
        {
            try
            {
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{baseCurrency}/{targetCurrency}/{amountToConvert}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro ao obter taxa de câmbio: {e.Message}");
                return null;
            }
        }
    }
}
