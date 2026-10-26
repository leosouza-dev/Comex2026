using Teste.Modelos;

namespace Teste.Menus;

public class MenuAdicionarCarrinho : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Adicionar Produto ao Carrinho");

        Console.Write("Informe o CPF do cliente: ");
        string cpf = Console.ReadLine()!;

        if (!clientes.ContainsKey(cpf))
        {
            Console.WriteLine("\nCliente não cadastrado.");
        }
        else
        {
            Console.Write("Informe o nome do produto que deseja adicionar: ");
            string nomeProduto = Console.ReadLine()!;

            Produto? produto = produtos.FirstOrDefault(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

            if (produto == null)
            {
                Console.WriteLine("\nProduto não encontrado.");
            }
            else
            {
                carrinhos[cpf].Add(produto);
                Console.WriteLine($"\nProduto '{produto.Nome}' adicionado ao carrinho de {clientes[cpf].Nome} com sucesso!");
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}