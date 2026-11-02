//using testeAula.Servicos;

//PostService service = new PostService();
//var posts = await service.ObterPostAsync();


//Console.WriteLine($"Total de Posts: {posts.Count}");

//var postsDoUser1 = posts
//    .Where(p => p.UsuarioId == 1)
//    .OrderBy(p => p.Titulo)
//    .ToList();

//Console.WriteLine("Posts do User1\n");
//foreach (var post in postsDoUser1)
//{
//    post.ExibirDetalhes();
//}


//var PostsPorusuario = posts
//    .GroupBy(p => p.UsuarioId)
//    .Select(g => new { UsuarioID = g.Key, TotalDePosts = g.Count() })
//    .ToList();

//Console.WriteLine("/nPosts por Usuario");
//foreach (var post in PostsPorusuario)
//{
//    Console.WriteLine($"UsuarioId: {post.UsuarioID}, TotalDePosts: {post.TotalDePosts}");
//}


//using HttpClient client = new HttpClient();
//async Task<string> ObterProdutoAsync(HttpClient client)
//{
//    string url = "url para ser consultada";
//    return await client.GetStringAsync(url);
//}


//using System.Text.Json;
//using testeAula.Modelos;

//string jsonResposta = "";

//var Pedidos = JsonSerializer.Deserialize<List<PedidoDto>>(jsonResposta);

Console.WriteLine("=== Teste de Produtos ===");

List<ProdutoDto> produtos = new()
{
    new ProdutoDto { Id = 1, Nome = "Teclado Mecânico", Categoria = "Periféricos", Preco = 250.00 },
    new ProdutoDto { Id = 2, Nome = "Mouse Gamer", Categoria = "Periféricos", Preco = 120.00 },
    new ProdutoDto { Id = 3, Nome = "Monitor Ultrawide", Categoria = "Monitores", Preco = 1400.00 },
    new ProdutoDto { Id = 4, Nome = "Cadeira Gamer", Categoria = "Móveis", Preco = 950.00 },
    new ProdutoDto { Id = 5, Nome = "Headset Sem Fio", Categoria = "Periféricos", Preco = 300.00 },
    new ProdutoDto { Id = 6, Nome = "Notebook Gamer", Categoria = "Computadores", Preco = 5500.00 },
    new ProdutoDto { Id = 7, Nome = "Mesa para Escritório", Categoria = "Móveis", Preco = 600.00 },
    new ProdutoDto { Id = 8, Nome = "Monitor 24 Polegadas", Categoria = "Monitores", Preco = 850.00 }
};

var perifericos = produtos.Where(p => p.Categoria == "Periféricos");

var produtosOrdenados = produtos.OrderByDescending(p => p.Preco);

var produtosPorCategoria = produtos.GroupBy(p => p.Categoria)
    .Select(g => new { Categoria = g.Key, Quantidade = g.Count() });

foreach (var grupo in produtosPorCategoria)
{
    Console.WriteLine($"Categoria: {grupo.Categoria}, Quantidade: {grupo.Quantidade}");
}

//foreach (var produto in produtosOrdenados)
//{
//    produto.ExibirDetalhes();
//}