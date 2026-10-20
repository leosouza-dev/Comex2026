




using testeAula;

Dictionary<string, string> clientes = new Dictionary<string, string>
{
    { "123", "Leo" },
    { "456", "Lari"}
};

//Dictionary<string, double> produtos = new Dictionary<string, double>
//{
//    { "coca", 10.00},
//    { "agua", 3.50}
//};

List<Produto> produtos = new List<Produto>();

//Produto produtoTeste = new("Livro");
//produtoTeste.PrecoUnitario = 100;

//Endereco enderecoDoLeo = new Endereco();
//enderecoDoLeo.Rua = "Paes de Barros";

//Cliente cliente = new Cliente();
//cliente.Nome = "Leo";
//cliente.Endereco = new Endereco() 
//{ 
//    Rua = "Paes de Barros",
//    Bairro = "Mooca"
//};
//Console.WriteLine($"Cliente: {cliente.Nome}, Endereço: {cliente.Endereco.Rua}");



//Dictionary<string, List<string>> carrinhos = new Dictionary<string, List<string>>();
Dictionary<string, List<string>> carrinhos = new Dictionary<string, List<string>>
{
    { "123", new List<string>{ "coca", "agua" } },
    { "456", new List<string>() }
};

void ExibirMenuDeOpcoes()
{
    // opções
    Console.Clear();
    Console.WriteLine("PROJETO COMEX");
    Console.WriteLine("\nDigite 1 para Cadastrar Cliente");
    Console.WriteLine("Digite 2 para Listar Clientes");
    Console.WriteLine("Digite 3 para Cadastrar Produto");
    Console.WriteLine("Digite 4 para Listar Produtos");
    Console.WriteLine("Digite 5 para alterar Preço do Produto");
    Console.WriteLine("Digite 6 para Adicionar Produto ao Carrinho");
    Console.WriteLine("Digite 7 para Fechar compra");
    Console.WriteLine("Digite -1 para encerrar o programa");

    // recupera valor digitado
    Console.Write("Digite sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    // verifica valor
    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;
        case 2:
            ListarClientes();
            break;
        case 3:
            CadastrarProduto();
            break;
        case 4:
            ListarProdutos();
            break;
        case 5:
            AlterarPrecoProduto();
            break;
        case 6:
            AdicionaProdutoNoCarrinho();
            break;
        case 7:
            FecharCompra();
            break;
        case -1:
            Console.WriteLine("\nFinalizado");
            break;
        default:
            Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            ExibirMenuDeOpcoes();
            break;
    }
}

void FecharCompra()
{
    //Console.Clear();
    //Console.WriteLine("=== FECHAR COMPRA ===");

    //Console.Write("Informe o CPF do cliente que quer fechar a compra: ");
    //string cpf = Console.ReadLine()!;

    //if (!clientes.ContainsKey(cpf))
    //{
    //    Console.WriteLine("\nCliente não cadastrado.");
    //    RetornarMenuPrincipal();
    //    return;
    //}

    //// buca todos os itens do carrinho
    //List<string> itensCarrinho = carrinhos[cpf];

    //if (itensCarrinho.Count == 0)
    //{
    //    Console.WriteLine($"\nO carrinho de {clientes[cpf]} está vazio.");
    //    RetornarMenuPrincipal();
    //}

    //Console.WriteLine($"\n--- Itens no Carrinho de {clientes[cpf]} ---");

    //double valorTotal = 0;
    //foreach (string item in itensCarrinho)
    //{
    //    double precoItem = produtos[item];
    //    Console.WriteLine($"- {item}: R$ {precoItem:F2}");
    //    valorTotal += precoItem;
    //}

    //Console.WriteLine($"-----------------------------------");
    //Console.WriteLine($"Valor total da compra: R$ {valorTotal:F2}");

    //Console.Write("\nDigite os dados do cartão de crédito: ");
    //string numeroCartao = Console.ReadLine()!;

    //Console.WriteLine($"\nRealizando pagamento de R$ {valorTotal:F2} no cartão {numeroCartao}.");

    //// Limpa o carrinho após fechar a compra
    //carrinhos[cpf].Clear();

    //RetornarMenuPrincipal();
}

void AdicionaProdutoNoCarrinho()
{
    //Console.Clear();
    //Console.WriteLine("=== ADICIONAR PRODUTO AO CARRINHO ===");

    //Console.Write("Informe o CPF do cliente que está comprando: ");
    //string cpf = Console.ReadLine()!;

    //if (!clientes.ContainsKey(cpf))
    //{
    //    Console.WriteLine("\nUsuário não cadastrado.");
    //    RetornarMenuPrincipal();
    //}

    //Console.Write("Informe o NOME do produto que deseja adicionar: ");
    //string nomeProduto = Console.ReadLine()!;

    //if (!produtos.ContainsKey(nomeProduto))
    //{
    //    Console.WriteLine("\nProduto não cadastrado.");
    //    RetornarMenuPrincipal();
    //}

    //carrinhos[cpf].Add(nomeProduto);
    //Console.WriteLine($"\nProduto '{nomeProduto}' adicionado ao carrinho de {clientes[cpf]} com sucesso!");

    //RetornarMenuPrincipal();
}

void AlterarPrecoProduto()
{
    //Console.Clear();
    //Console.WriteLine("- Alterar Preço do Produto -");

    //Console.WriteLine("\nDigite o nome do produto para alterar o preço");
    //string nome = Console.ReadLine()!;

    //if (!produtos.ContainsKey(nome))
    //{
    //    Console.WriteLine("\nProduto não encontrado");
    //    ExibirMenuDeOpcoes();
    //}

    //Console.WriteLine("Digite o valo atualizado: ");
    //double valor = double.Parse(Console.ReadLine()!);
    //produtos[nome] = valor;

    //Console.WriteLine($"\n{nome} teve o valor alterado com sucesso - R${valor:F2}");
    //RetornarMenuPrincipal();

}

void ListarProdutos()
{
    Console.Clear();
    Console.WriteLine("Listar Produtos");

    foreach (var produto in produtos)
    {
        produto.ExibirInformacoes();
        //produto.
    }

    RetornarMenuPrincipal();
}

void CadastrarProduto()
{
    Console.Clear();
    Console.WriteLine("- Cadastro de Produto -");

    Console.WriteLine("Digite o nome do produto: ");
    string nome = Console.ReadLine()!;

    // validar se o foi informado o nome (não pode ser nulo)...

    Produto produto = new Produto(nome);

    Console.WriteLine("Digite a descrição do produto: ");
    produto.Descricao = Console.ReadLine()!;

    Console.WriteLine("Digite o preço do produto: ");
    produto.PrecoUnitario = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite a quantidade em estoque: ");
    produto.Quantidade = int.Parse(Console.ReadLine()!);

    produtos.Add(produto);
    Console.WriteLine($"{nome} adicionado com sucesso!");

    RetornarMenuPrincipal();
}

void CadastrarCliente()
{
    Console.Clear();
    Console.WriteLine("- Cadastro de Cliente -");

    Console.WriteLine("\nDigite o cpf do cliente: ");
    string cpf = Console.ReadLine()!;

    if (clientes.ContainsKey(cpf))
    {
        Console.WriteLine("Erro: Esse CPF já está cadastrado!");
        RetornarMenuPrincipal();
    }
    else
    {
        Console.WriteLine("\nDigite o nome do cliente: ");
        string nome = Console.ReadLine()!;

        clientes.Add(cpf, nome);

        // quando for fazer o carrinho
        carrinhos.Add(cpf, new List<string>());

        Console.WriteLine($"\n{nome} cadastrado com sucesso");
        RetornarMenuPrincipal();
    }
}

void ListarClientes()
{
    Console.Clear();

    Console.WriteLine("- Listar Clientes -");

    Console.WriteLine("\nLista de CLientes\n");
    foreach (var cliente in clientes)
    {
        Console.WriteLine($"nome: {cliente.Value}, cpf: {cliente.Key}");
    }

    RetornarMenuPrincipal();
}


void RetornarMenuPrincipal()
{
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial...");
    Console.ReadKey();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();