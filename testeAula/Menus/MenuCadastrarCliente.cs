using Teste.Menus;
using Teste.Modelos;

namespace Teste.Menus;

public class MenuCadastrarCliente : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Cadastro de Cliente");

        Console.Write("Digite o CPF do cliente: ");
        string cpf = Console.ReadLine()!;

        if (clientes.ContainsKey(cpf))
        {
            Console.WriteLine("\nErro: Esse CPF já está cadastrado!");
        }
        else
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine()!;

            Cliente novoCliente = new Cliente(nome, cpf);
            clientes.Add(cpf, novoCliente);
            carrinhos.Add(cpf, new List<Produto>());

            Console.WriteLine($"\nCliente {nome} cadastrado com sucesso!");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}