using Teste.Modelos;

namespace Teste.Menus;

public class MenuListarProdutos : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Lista de Produtos");

        Console.WriteLine("Como deseja ordenar a lista?");
        Console.WriteLine("1 - Por Título (Nome)");
        Console.WriteLine("2 - Por Preço");
        Console.Write("Escolha uma opção: ");
        string escolha = Console.ReadLine()!;

        List<Produto> produtosOrdenados = escolha switch
        {
            "1" => produtos.OrderBy(p => p.Nome).ToList(),
            "2" => produtos.OrderBy(p => p.PrecoUnitario).ToList(),
            _ => produtos
        };

        Console.WriteLine();
        foreach (var produto in produtosOrdenados)
        {
            produto.ExibirInformacoes();
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}