
using System.Text.Json.Serialization;

namespace testeAula.Modelos
{
    internal class PostDto
    {
        [JsonPropertyName("userId")]
        public int UsuarioId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string? Titulo { get; set; }

        [JsonPropertyName("body")]
        public string? Body { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"User: {UsuarioId}, Id: {Id}, Titulo: {Titulo}");
        }
    }
}
