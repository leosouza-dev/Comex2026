using System.Net.Http;
using System.Text.Json;
using Teste.Modelos;

namespace Teste.Servicos;

public class ProdutoService
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<List<ProdutoApi>> ObterProdutosDaApiAsync()
    {
        string url = "https://fakestoreapi.com/products";

        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();

            var opcoes = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<ProdutoApi>? produtos = JsonSerializer.Deserialize<List<ProdutoApi>>(jsonResponse, opcoes);

            return produtos ?? new List<ProdutoApi>();
        }
        catch (HttpRequestException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[Erro de Rede/HTTP]: Falha ao comunicar com a API. Detalhes: {ex.Message}");
            Console.ResetColor();
            return new List<ProdutoApi>();
        }
        catch (JsonException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[Erro de Desserialização]: Formato de JSON inválido. Detalhes: {ex.Message}");
            Console.ResetColor();
            return new List<ProdutoApi>();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[Erro Inesperado]: {ex.Message}");
            Console.ResetColor();
            return new List<ProdutoApi>();
        }
    }
}