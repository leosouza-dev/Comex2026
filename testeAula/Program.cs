using GestaoFrota.Modelos;

Carro carro1 = new("123", "BYD");
carro1.ValorDiaria = 100;
Console.WriteLine($"Total de Carros: {Carro.TotalCarros}");

Carro carro2 = new("141", "BYD");
Console.WriteLine($"Total de Carros: {Carro.TotalCarros}");

var caminhao = new Caminhao();
caminhao.Eixos = 3;
caminhao.ValorDiaria = 100;

var valor = caminhao.CalcularAluguel(2);
Console.WriteLine($"Valor do aluguel: {valor}");


List<Veiculo> frota = new List<Veiculo>();
frota.Add(carro1);
frota.Add(caminhao);

foreach (var veiculo in frota)
{
    var total = veiculo.CalcularAluguel(5);
    Console.WriteLine($"Custo do Aluguel: R${total}");
}

Console.WriteLine(caminhao.ObterLocalizacao()); 