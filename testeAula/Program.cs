
using testeAula.Models;

GerenciadorDeContas gerenciador = new GerenciadorDeContas();
GerenciadorDeImpostos gerenciadorDeImpostos = new GerenciadorDeImpostos();

var conta01 = new ContaCorrente("Leo", 100);
Console.WriteLine($"conta do {conta01.Titular}, Saldo:{conta01.Saldo},  numero: {conta01.Numero}");
conta01.Sacar(10);
Console.WriteLine($"conta do {conta01.Titular}, Saldo:{conta01.Saldo},  numero: {conta01.Numero}");

gerenciador.Adicionar(conta01);

//

var conta02 = new ContaInvestimento("caio", 200);
Console.WriteLine($"conta do {conta02.Titular}, Saldo:{conta02.Saldo}, numero: {conta02.Numero}");
conta02.Sacar(10);
Console.WriteLine($"conta do {conta02.Titular}, Saldo:{conta02.Saldo}, numero: {conta02.Numero}");

gerenciador.Adicionar(conta02);

Console.WriteLine($"Valor Total no Banco: {gerenciador.TotalDoBanco}");

//

SeguroDeVida seguro = new SeguroDeVida();
seguro.ValorPremio = 500;

//

gerenciadorDeImpostos.Registrar(seguro);
gerenciadorDeImpostos.Registrar(conta01);
//gerenciadorDeImpostos.Registrar(conta02);

Console.WriteLine($"Valor Total de Imposto Recolhido: {gerenciadorDeImpostos.TotalDeImposto}");

