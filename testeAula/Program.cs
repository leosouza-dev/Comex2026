




Dictionary<string, string> clientes = new Dictionary<string, string> 
{
    { "123", "Leo" },
    { "456", "Lari" },
    { "789", "Caio" },
};

Dictionary<string, double> produtos = new Dictionary<string, double>
{
    { "coca", 8.00},
    { "agua", 1.50 }
};

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("-- PROJETO COMEX --");
    //Exibir a opção de cadastrar
    Console.WriteLine("\nDigite 1 para Cadastrar um Cliente!");
    Console.WriteLine("Digite 2 para Listar os Clientes!");
    Console.WriteLine("Digite 3 para Cadastrar um Produto!");
    Console.WriteLine("Digite 4 para Listar os Produtos!");
    Console.WriteLine("Digite 5 para Alterar o preço do Produto!");

    //armazenar o valor que foi digitado (int)
    Console.Write("\nDigite a sua opção: ");
    string opcaoString = Console.ReadLine()!; // "1"

    if(int.TryParse(opcaoString, out var opcao))
    {
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
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("\nValor inválido, tente novamente...");
        Console.WriteLine("Teste hot-reload");
        VoltarAoMenuPrincipal();
    }

    //try
    //{
    //    int opcao = int.Parse(opcaoString); // 1

    //    //verifica o valor digitado
    //    switch (opcao)
    //    {
    //        case 1:
    //            CadastrarCliente();
    //            break;
    //        case 2:
    //            ListarClientes();
    //            break;
    //        default:
    //            break;
    //    }
    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Valor inválido, tente novamente...");
    //    VoltarAoMenuPrincipal();
    //}
    //execução do opção selecionada
}

void AlterarPrecoProduto()
{
    Console.Clear();
    Console.WriteLine("-- Alterar Preço do Produto --\n");

    Console.WriteLine("Digite o nome do Produto para alterar o preço: ");
    string nome = Console.ReadLine()!;

    if (!produtos.ContainsKey(nome))
    {
        Console.WriteLine("\nProduto não encontrado");
        VoltarAoMenuPrincipal();
    }

    Console.WriteLine("Digite o valor atualizado: ");
    double valor = double.Parse(Console.ReadLine()!);

    produtos[nome] = valor;

    Console.WriteLine($"{nome} teve o valor alterado com sucesso - R${valor:F2}");
    VoltarAoMenuPrincipal();
}

void ListarProdutos()
{
    Console.Clear();
    Console.WriteLine("-- Produto Cadastrados --\n");

    foreach (var produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Key} | R${produto.Value:F2}");
    }

    VoltarAoMenuPrincipal();
}

void CadastrarProduto()
{
    Console.Clear();
    Console.WriteLine("-- Cadastro de Produtos --");

    Console.WriteLine("\nDigite o nome do produto: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite o preço do produto: ");
    double preco = double.Parse(Console.ReadLine()!);

    produtos.Add(nome, preco);
    Console.WriteLine($"{nome} foi adcionado com sucesso!!!");

    VoltarAoMenuPrincipal();
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("-- Listagem de Clientes --");

    Console.WriteLine("\nClientes cadastrados...\n");
    foreach (KeyValuePair<string, string> cliente in clientes)
    {
        Console.WriteLine($"Nome: {cliente.Value}, CPF:{cliente.Key}");
        // diversos codigo...
    }

    VoltarAoMenuPrincipal();
}

void CadastrarCliente()
{
    // limpar a tela
    Console.Clear();
    Console.WriteLine("-- Cadastro de Cliente --");

    // pedir para digir e guardar o cpf
    Console.WriteLine("\nDigite o CPF do cliente: ");
    string cpf = Console.ReadLine()!;

    if (clientes.ContainsKey(cpf))
    {
        Console.WriteLine("Erro: CPF já está cadastrado...");
        VoltarAoMenuPrincipal();
    }

    // pedir para digir e guardar o nome
    Console.WriteLine("Digite o nome do Cliente: ");
    string nome = Console.ReadLine()!;

    // cadastrar o cliente (cpf/nome) no dicionario
    clientes.Add(cpf, nome);

    // Mensagem de sucesso!
    Console.WriteLine($"\n{nome} cadastrado com sucesso!!!");

    // voltar para o menu principal
    VoltarAoMenuPrincipal();
}

void VoltarAoMenuPrincipal()
{
    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal!!!");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();