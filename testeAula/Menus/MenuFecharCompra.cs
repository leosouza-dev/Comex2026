using Teste.Modelos;

namespace Teste.Menus;

public class MenuFecharCompra : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Fechar Compra");

        Console.Write("Informe o CPF do cliente: ");
        string cpf = Console.ReadLine()!;

        if (!clientes.ContainsKey(cpf))
        {
            Console.WriteLine("\nCliente não cadastrado.");
        }
        else
        {
            List<Produto> itensCarrinho = carrinhos[cpf];

            if (itensCarrinho.Count == 0)
            {
                Console.WriteLine($"\nO carrinho de {clientes[cpf].Nome} está vazio.");
            }
            else
            {
                Console.WriteLine($"\n--- Itens no Carrinho de {clientes[cpf].Nome} ---");
                double valorTotal = 0;

                foreach (var item in itensCarrinho)
                {
                    Console.WriteLine($"- {item.Nome}: R$ {item.PrecoUnitario:F2}");
                    valorTotal += item.PrecoUnitario;
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Valor total da compra: R$ {valorTotal:F2}");

                Console.Write("\nDigite os dados do cartão de crédito: ");
                string numeroCartao = Console.ReadLine()!;

                Console.WriteLine($"\nPagamento de R$ {valorTotal:F2} realizado com sucesso no cartão {numeroCartao}!");
                itensCarrinho.Clear();
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}