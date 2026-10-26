using Teste.Modelos;

namespace Teste.Menus;

public class MenuAlterarPreco : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Alterar Preço do Produto");

        Console.Write("Digite o nome do produto que deseja alterar: ");
        string nome = Console.ReadLine()!;

        Produto? produto = produtos.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

        if (produto == null)
        {
            Console.WriteLine("\nProduto não encontrado!");
        }
        else
        {
            Console.Write("Digite o valor atualizado: ");
            double novoPreco = double.Parse(Console.ReadLine()!);
            produto.PrecoUnitario = novoPreco;

            Console.WriteLine($"\nO preço de '{produto.Nome}' foi alterado para R$ {novoPreco:F2} com sucesso!");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}