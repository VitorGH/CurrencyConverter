using System.Text.Json;

namespace CurrencyConverter
{
    public class Converter
    {
        static public async Task Execute(string baseCurrency, string targetCurrency, decimal amountToConvert)
        {   
            string? response = await API.GetExchangeRateAsync(baseCurrency, targetCurrency, amountToConvert);
            Console.WriteLine($"Convertendo {baseCurrency} para {targetCurrency}");

            if (response == null)
            {
                Console.WriteLine("Erro ao obter a taxa de câmbio. Verifique a moeda e tente novamente.");
                return;
            }

            using var doc = JsonDocument.Parse(response);
            if (doc.RootElement.TryGetProperty("conversion_result", out var result))
            {
                Console.WriteLine($"Resulado: {result}");
            } else
            {
                Console.WriteLine("Não foi possível obter o resultado da conversão. Verifique a moeda e tente novamente.");
            }

        }
    }
}
