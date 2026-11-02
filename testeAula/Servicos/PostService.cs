using System.Text.Json;
using testeAula.Modelos;
using static System.Net.WebRequestMethods;

namespace testeAula.Servicos
{
    internal class PostService
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<List<PostDto>> ObterPostAsync()
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/posts";

                Console.WriteLine($"Conectando a api em {url}...");
                var resposta = await _client.GetStringAsync(url);

                //var opc = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                //var posts = JsonSerializer.Deserialize<List<PostDto>>(resposta, opc);

                var posts = JsonSerializer.Deserialize<List<PostDto>>(resposta);
                return posts ?? new List<PostDto>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nERRO de HTPP: {ex.Message}");
                return new List<PostDto>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nERRO INESPERADO: {ex.Message}");
                return new List<PostDto>();
            }

        }
    }
}
