using Teste.Menus;
using Teste.Modelos;

Dictionary<string, Cliente> clientes = new()
{
    { "123", new Cliente("Leo", "123") },
    { "456", new Cliente("Lari", "456") }
};

List<Produto> produtos = new()
{
    new Produto("Coca", 10.00, 50),
    new Produto("Água", 3.50, 100),
    new Livro("Clean Code", 85.00, 15, "978-8576082675", 425)
};

Dictionary<string, List<Produto>> carrinhos = new()
{
    { "123", new List<Produto> { produtos[0] } },
    { "456", new List<Produto>() }
};

Dictionary<int, Menu> opcoesMenu = new()
{
    { 1, new MenuCadastrarCliente() },
    { 2, new MenuListarClientes() },
    { 3, new MenuCadastrarProduto() },
    { 4, new MenuListarProdutos() },
    { 5, new MenuAlterarPreco() },
    { 6, new MenuAdicionarCarrinho() },
    { 7, new MenuFecharCompra() }
};

void ExibirMenuDeOpcoes()
{
    Console.Clear();
    Console.WriteLine("PROJETO COMEX");
    Console.WriteLine("\nDigite 1 para Cadastrar Cliente");
    Console.WriteLine("Digite 2 para Listar Clientes");
    Console.WriteLine("Digite 3 para Cadastrar Produto");
    Console.WriteLine("Digite 4 para Listar Produtos (com Ordenação LINQ)");
    Console.WriteLine("Digite 5 para Alterar Preço do Produto");
    Console.WriteLine("Digite 6 para Adicionar Produto ao Carrinho");
    Console.WriteLine("Digite 7 para Fechar Compra");
    Console.WriteLine("Digite -1 para Encerrar o Programa");

    Console.Write("\nDigite sua opção: ");
    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        if (opcao == -1)
        {
            Console.WriteLine("\nPrograma finalizado com sucesso!");
            return;
        }

        if (opcoesMenu.ContainsKey(opcao))
        {
            opcoesMenu[opcao].Executar(clientes, produtos, carrinhos);
            ExibirMenuDeOpcoes();
        }
        else
        {
            Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente.");
            Console.ReadKey();
            ExibirMenuDeOpcoes();
        }
    }
    else
    {
        Console.WriteLine("\nEntrada inválida! Pressione qualquer tecla para tentar novamente.");
        Console.ReadKey();
        ExibirMenuDeOpcoes();
    }
}

ExibirMenuDeOpcoes();