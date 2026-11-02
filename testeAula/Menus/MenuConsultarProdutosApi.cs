using Teste.Modelos;
using Teste.Servicos;

namespace Teste.Menus;

public class MenuConsultarProdutosApi : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtosLocais, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtosLocais, carrinhos);
        ExibirTitulo("CONSULTA DE PRODUTOS DA API EXTERNA");

        ProdutoService servico = new ProdutoService();

        Console.WriteLine("Buscando produtos da API externa, aguarde...\n");

        List<ProdutoApi> produtosApi = servico.ObterProdutosDaApiAsync().GetAwaiter().GetResult();

        if (produtosApi.Count > 0)
        {
            Console.WriteLine($"Sucesso! {produtosApi.Count} produtos encontrados.\n");

            Console.WriteLine("--- Lista Original da API ---");
            foreach (var p in produtosApi)
            {
                p.ExibirDetalhes();
            }

            // TAREFA TRELLO: Ordenação com LINQ
            Console.WriteLine("\nDeseja ordenar os produtos da API?");
            Console.WriteLine("1 - Ordenar por Título (Nome)");
            Console.WriteLine("2 - Ordenar por Preço");
            Console.WriteLine("0 - Voltar ao Menu Principal");
            Console.Write("\nEscolha uma opção: ");
            string? opcaoOrdenacao = Console.ReadLine();

            if (opcaoOrdenacao == "1")
            {
                var ordenadosPorTitulo = produtosApi.OrderBy(p => p.Title).ToList();
                ExibirTitulo("PRODUTOS ORDENADOS POR TÍTULO");
                foreach (var p in ordenadosPorTitulo)
                {
                    p.ExibirDetalhes();
                }
            }
            else if (opcaoOrdenacao == "2")
            {
                var ordenadosPorPreco = produtosApi.OrderBy(p => p.Price).ToList();
                ExibirTitulo("PRODUTOS ORDENADOS POR PREÇO");
                foreach (var p in ordenadosPorPreco)
                {
                    p.ExibirDetalhes();
                }
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
    }
}