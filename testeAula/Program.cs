// Array
//int[] estoque = new int[2];
//estoque[0] = 10;
//estoque[1] = 20;

//string[] produtos = { "Dipirona", "Paracetamol" };

//Console.WriteLine($"Quantidade de Produtos: {produtos.Length}");
//Console.WriteLine($"Primeiro Produto: {produtos[2]}, Estoque {estoque[0]}");




//Arraylist
//using System.Collections;

//var lista = new ArrayList();
//lista.Add("Dipirona");
//lista.Add(10);

//foreach (var item in lista)
//{
//    Console.WriteLine(item);
//}

//int nome = (int)lista[0];







// List
var produtos = new List<string> { "Dipirona", "Paracetamol" };
produtos.Add("Ibuprofeno");
produtos.Insert(0, "Ibuprofeno");

foreach (var item in produtos)
{
    Console.WriteLine(item);
}




// Hashset
//var codigos = new HashSet<string>() { "A1", "B2", "C3" };
//var adicionou = codigos.Add("A1");
//Console.WriteLine($" Adicionou o A1 novamente: {adicionou}, Total de Elementos: {codigos.Count}");





// Dicionario
//var precos = new Dictionary<string, decimal>
//{
//    //{ "Dipirona", 5.50m },
//    //{ "Paracetamol", 15.50m }
//    ["Dipirona"] = 5.50m,
//    ["Paracetamol"] = 15.50m
//};

//precos["Amoxilina"] = 30.00m;

//precos["Dipirona"] = 30.00m;

//foreach (KeyValuePair<string, decimal> item in precos)
//{
//    Console.WriteLine(item.Key);
//}





// Stack - lifo (push, pop, peek)
//var historico = new Stack<string>();
//historico.Push("Abriu a tela de pedidos");
//historico.Push("Selecionou o produto Dipirona");
//historico.Push("Alterou a quantidade");

//Console.WriteLine($"Topo (peek): {historico.Peek()}");
//Console.WriteLine($"Desfazer (pop): {historico.Pop()}");
//Console.WriteLine($"Topo (peek): {historico.Peek()}");





// Queue - Fila - 
//var fila = new Queue<string>();
//fila.Enqueue("Senha001");
//fila.Enqueue("Senha002");
//fila.Enqueue("Senha003");

//Console.WriteLine($"Primeiro (peek): {fila.Peek()}");

//while(fila.Count > 0)
//    Console.WriteLine($"Atendendo {fila.Dequeue()}");


// IEnumerable, ICollection, IComparable e IComparer - YIELD RETURN



var pedidos = new List<Pedido>
{
new(3, "Losartana", 1, 12.00m),
new(1, "Dipirona", 2, 5.50m),
new(2, "Omeprazol", 5, 18.90m),
};

// Sort() sem argumentos usa IComparable<Pedido> -> ordem natural = por Id.
pedidos.Sort();
Console.WriteLine("Por Id (IComparable):");
pedidos.ForEach(p => Console.WriteLine($" {p}"));

// Sort(comparer) usa IComparer<Pedido> -> ordem alternativa = por total.
pedidos.Sort(new PorTotalDecrescente());
Console.WriteLine("Por total decrescente (IComparer):");
pedidos.ForEach(p => Console.WriteLine($" {p}"));

record Pedido(int Id, string Produto, int Quantidade, decimal PrecoUnitario) : IComparable<Pedido>
{
    public decimal Total => Quantidade * PrecoUnitario;

    // Negativo = este vem antes; 0 = iguais; positivo = este vem depois.
    public int CompareTo(Pedido? outro) => outro is null ? 1 : Id.CompareTo(outro.Id);
}

class PorTotalDecrescente : IComparer<Pedido>
{
    public int Compare(Pedido? a, Pedido? b)
    {
        if (a is null || b is null) return 0;
        return b.Total.CompareTo(a.Total); // invertido para ficar decrescente
    }
}