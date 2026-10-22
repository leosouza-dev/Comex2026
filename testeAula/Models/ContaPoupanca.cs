namespace testeAula.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, double saldo) : base(titular, saldo)
        {
        }

        public override void CalcularTaxaManutencao()
        {
            Saldo -= 1;
        }
    }
}
