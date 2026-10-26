using Teste.Modelos;

namespace Teste.Menus;

public class Menu
{
    public virtual void Executar(Dictionary<string, Cliente> clientes, List<Produto> produtos, Dictionary<string, List<Produto>> carrinhos)
    {
        Console.Clear();
    }

    protected void ExibirTitulo(string titulo)
    {
        Console.Clear();
        Console.WriteLine($"=== {titulo} ===");
        Console.WriteLine();
    }
}