using System.Text.Json.Serialization;

namespace Teste.Modelos;

public class ProdutoApi
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("price")]
    public double Price { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"ID: {Id} | Título: {Title} | Preço: R$ {Price:F2} | Categoria: {Category}");
    }
}