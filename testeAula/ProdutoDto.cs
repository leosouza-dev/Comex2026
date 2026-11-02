//using testeAula.Servicos;

public class ProdutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double Preco { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"ID: {Id}, Preço: {Preco}, Produto: {Nome}, Categoria: {Categoria}");
    }
}