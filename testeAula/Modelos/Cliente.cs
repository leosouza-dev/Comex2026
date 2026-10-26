using Teste.Interfaces;

namespace Teste.Modelos;

public class Cliente : IIdentificavel
{
    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public Endereco Endereco { get; set; } = new();

    public string Identificar()
    {
        return $"Cliente: {Nome} | CPF: {Cpf}";
    }
}