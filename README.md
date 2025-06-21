# Currency Converter (Console App)

Uma aplicação de console simples para conversão de moedas em tempo real utilizando a API [ExchangeRate-API](https://app.exchangerate-api.com).

## 📋 Descrição

Este é um sistema de conversão de moedas que permite ao usuário converter valores entre diferentes moedas (ex: USD → EUR, BRL → USD, etc). Ele acessa a API pública da ExchangeRate-API para obter as taxas de câmbio mais recentes.

## ✅ Funcionalidades

- Escolha de moeda base (ex: USD, BRL, JPY)
- Escolha de moeda de destino (ex: EUR, GBP, CAD)
- Conversão de um valor especificado
- Retorno direto no console

## 🚀 Como executar

### Pré-requisitos:

- .NET 6.0 ou superior instalado em sua máquina.

### Passo a passo:

1. Clone ou baixe o repositório.

2. **Crie uma conta gratuita em:**

   👉 [https://app.exchangerate-api.com](https://app.exchangerate-api.com)

3. **Obtenha sua API Key** e salve em um arquivo chamado `apikey.txt` na mesma pasta onde o programa será executado.

   Exemplo de conteúdo do arquivo:

   ```
   SUA_API_KEY_AQUI
   ```

4. Compile o projeto:

   ```bash
   dotnet build
   ```

5. Execute a aplicação:

   ```bash
   dotnet run
   ```

## 🧑‍💻 Exemplo de uso:

```
Sistema conversor de moedas!

**MENU**
0 - Encerrar
1 - Iniciar conversão

Opção: 1
Digite a sigla da moeda base (USD, BRL, JPY): USD
Digite a quantidade a ser convertida: 100
Digite a sigla da moeda de destino (EUR, GBP, CAD): EUR
Convertendo USD para EUR
Resultado: 92.50
```

## 📌 Observações:

- A API gratuita da ExchangeRate-API tem um limite de requisições por mês. Consulte o plano que você escolher.
- O programa lê a chave da API do arquivo `apikey.txt`, então não esqueça de criá-lo antes de executar.
