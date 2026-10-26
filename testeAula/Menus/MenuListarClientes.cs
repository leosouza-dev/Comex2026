using Teste.Modelos;

namespace Teste.Menus;

public class MenuListarClientes : Menu
{
    public override void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        base.Executar(clientes, produtos, carrinhos);
        ExibirTitulo("Lista de Clientes");

        foreach (var cliente in clientes.Values)
        {
            Console.WriteLine($"- {cliente.Identificar()}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}