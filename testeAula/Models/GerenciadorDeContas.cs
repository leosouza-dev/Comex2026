namespace testeAula.Models
{
    public class GerenciadorDeContas
    {
        public double TotalDoBanco { get; private set; }

        public void Adicionar(Conta conta)
        {
            TotalDoBanco += conta.Saldo;
        }
    }
}
