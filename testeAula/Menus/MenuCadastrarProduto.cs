using Teste.Modelos;

namespace Teste.Menus;

public class MenuCadastrarProduto : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Cadastro de Produto");

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite a descrição do produto: ");
        string descricao = Console.ReadLine()!;

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        Produto produto = new Produto(nome, preco, quantidade) { Descricao = descricao };
        produtos.Add(produto);

        Console.WriteLine($"\nProduto '{nome}' adicionado com sucesso!");
        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}