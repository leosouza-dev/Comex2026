//using System;
//using System.Collections.Generic;

//class Program
//{
//    // Declarado como um campo estático da classe
//    static Dictionary<string, List<string>> estoqueCategorizado = new();

//    static void Main()
//    {
//        AdicionarProduto("Bebidas", "Coca-Cola");
//        AdicionarProduto("Bebidas", "Água Mineral");
//        AdicionarProduto("Eletrônicos", "Smartphone");

//        foreach (var categoria in estoqueCategorizado)
//        {
//            Console.WriteLine($"Categoria: {categoria.Key}");
//            foreach (var produto in categoria.Value)
//            {
//                Console.WriteLine($"  - {produto}");
//            }
//        }
//    }

//    // Como o dicionário agora é da classe, não precisamos passá-lo por parâmetro
//    static void AdicionarProduto(string categoria, string produto)
//    {
//        if (!estoqueCategorizado.ContainsKey(categoria))
//        {
//            estoqueCategorizado[categoria] = new List<string>();
//        }
//        estoqueCategorizado[categoria].Add(produto);
//    }
//}


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<Produto> produtos = new List<Produto>
//        {
//            new Produto("Notebook", 4500.00m),
//            new Produto("Mouse", 150.00m),
//            new Produto("Teclado", 300.00m)
//        };

//        // Ordenando pelo IComparable (Preço)
//        produtos.Sort();
//        Console.WriteLine("--- Ordenado por Preço ---");
//        produtos.ForEach(Console.WriteLine);

//        // Ordenando pelo IComparer customizado (Nome)
//        produtos.Sort(new ComparadorProdutoPorNome());
//        Console.WriteLine("\n--- Ordenado por Nome (A-Z) ---");
//        produtos.ForEach(Console.WriteLine);
//    }
//}

//public class Produto : IComparable<Produto>
//{
//    public string Nome { get; set; }
//    public decimal Preco { get; set; }

//    public Produto(string nome, decimal preco)
//    {
//        Nome = nome;
//        Preco = preco;
//    }

//    // Ordenação natural padrão por Preço (crescente)
//    public int CompareTo(Produto? outro)
//    {
//        if (outro == null) return 1;
//        return Preco.CompareTo(outro.Preco);
//    }

//    public override string ToString() => $"{Nome} - R$ {Preco:F2}";
//}

//// Comparador alternativo por Nome (A-Z)
//public class ComparadorProdutoPorNome : IComparer<Produto>
//{
//    public int Compare(Produto? x, Produto? y)
//    {
//        if (x == null || y == null) return 0;
//        return string.Compare(x.Nome, y.Nome, StringComparison.Ordinal);
//    }
//}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> filaAtendimento = new Queue<string>();

        // Adicionando clientes à fila (Enqueue)
        filaAtendimento.Enqueue("Ana");
        filaAtendimento.Enqueue("Bruno");
        filaAtendimento.Enqueue("Carlos");

        // Consultando quem é o próximo da fila sem removê-lo (Peek)
        if (filaAtendimento.Count > 0)
        {
            Console.WriteLine($"Próximo cliente a ser atendido: {filaAtendimento.Peek()}\n");
        }

        // Processando o atendimento (Dequeue)
        Console.WriteLine("--- Iniciando Atendimentos ---");
        while (filaAtendimento.Count > 0)
        {
            string clienteAtual = filaAtendimento.Dequeue();
            Console.WriteLine($"Atendendo agora: {clienteAtual}");
        }

        Console.WriteLine("\nFila de atendimento finalizada.");
    }
}