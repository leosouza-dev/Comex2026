namespace Teste.Modelos;

public class Produto
{
    public Produto(string nome, double precoUnitario, int quantidade)
    {
        Nome = nome;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public string Nome { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"[Produto] Nome: {Nome} | Descrição: {Descricao} | Preço: R$ {PrecoUnitario:F2} | Qtd: {Quantidade}");
    }
}