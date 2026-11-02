using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeAula.Servicos;

internal class ProdutoService
{
    private static readonly HttpClient _client = new HttpClient();


    public async Task<string> ObterProdutosAsync()
    {
        try
        {
            string url = "https://api.minhaempresa.com/v1/produtos";
            return await _client.GetStringAsync(url);
        }
        catch (HttpRequestException)
        {
            // trata a exception
            throw;
        }
        catch (Exception)
		{
            // trata a exception
            throw;
		}
        
    }
}
