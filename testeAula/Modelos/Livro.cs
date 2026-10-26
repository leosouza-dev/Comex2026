using Teste.Interfaces;

namespace Teste.Modelos;

public class Livro : Produto, IIdentificavel
{
    public Livro(string nome, double precoUnitario, int quantidade, string isbn, int totalPaginas)
        : base(nome, precoUnitario, quantidade)
    {
        Isbn = isbn;
        TotalPaginas = totalPaginas;
    }

    public string Isbn { get; set; }
    public int TotalPaginas { get; set; }

    public string Identificar()
    {
        return $"Livro: {Nome} | ISBN: {Isbn}";
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Livro] Nome: {Nome} | Preço: R$ {PrecoUnitario:F2} | ISBN: {Isbn} | Páginas: {TotalPaginas}");
    }
}