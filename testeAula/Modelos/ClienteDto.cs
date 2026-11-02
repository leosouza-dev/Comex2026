using System.Text.Json.Serialization;

namespace testeAula.Modelos;

internal class ClienteDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("ativo")]
    public bool Ativo { get; set; }
}
