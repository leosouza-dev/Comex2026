namespace Teste.Modelos;

public class Eletronico : Produto
{
    public Eletronico(string nome, double precoUnitario, int quantidade, int voltagem, double potencia)
        : base(nome, precoUnitario, quantidade)
    {
        Voltagem = voltagem;
        Potencia = potencia;
    }

    public int Voltagem { get; set; }
    public double Potencia { get; set; }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Eletrônico] Nome: {Nome} | Preço: R$ {PrecoUnitario:F2} | Voltagem: {Voltagem}V | Potência: {Potencia}W");
    }
}