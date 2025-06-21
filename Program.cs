using System;
using System.Globalization;
using System.Threading;
using CurrencyConverter;

static void Print(string message)
{
    Console.WriteLine(message);
}

while (true)
{
    Print("Sistema conversor de moedas!\n");
    Print("**MENU** \n0 - Encerrar\n1 - Iniciar conversão\n");

    Console.Write("Opção: ");
    string? option = Console.ReadLine();
    
    switch (option)
    {
        default:
            Print("Opção inválida, tente novamente.\n");
            break;
        case "0":
            Print("Saindo do sistema...\n");
            return;
        case "1":
            try
            {
                Print("Digite a sigla da moeda base (USD, BRL, JPY): ");
                string baseCurrency = Console.ReadLine().ToUpperInvariant();

                Print("Digite a quantidade a ser convertida: ");
                decimal amountToConvert = decimal.Parse(Console.ReadLine());

                Print("Digite a sigla da moeda de destino (EUR, GBP, CAD): ");
                string targetCurrency = Console.ReadLine().ToUpperInvariant();

                await Converter.Execute(baseCurrency, targetCurrency, amountToConvert);
            }
            catch (Exception ex)
            {
                Print($"Erro ao iniciar a conversão: {ex.Message}");
                continue;
            }
            break;
    }

    Thread.Sleep(100);
}
