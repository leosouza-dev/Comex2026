

Dictionary<string, string> clientes = new Dictionary<string, string> 
{
    { "123", "Leo" },
    { "456", "Lari" },
    { "789", "Caio" },
};

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("-- PROJETO COMEX --");
    //Exibir a opção de cadastrar
    Console.WriteLine("\nDigite 1 para Cadastrar um Cliente!");
    Console.WriteLine("Digite 2 para Listar os Clientes!");

    //armazenar o valor que foi digitado (int)
    Console.Write("\nDigite a sua opção: ");
    string opcaoString = Console.ReadLine()!; // "1"
    int opcao = int.Parse(opcaoString); // 1

    //verifica o valor digitado
    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;
        case 2:
            ListarClientes();
            break;
        default:
            break;
    }

    //execução do opção selecionada
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("-- Listagem de Clientes --");

    Console.WriteLine("\nClientes cadastrados...\n");
    foreach (KeyValuePair<string, string> cliente in clientes)
    {
        Console.WriteLine($"Nome: {cliente.Value}, CPF:{cliente.Key}");
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