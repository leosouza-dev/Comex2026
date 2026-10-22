namespace testeAula.Models
{
    public class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(string titular, double saldo) : base(titular, saldo)
        {
        }

        public double CalcularImposto()
        {
            return Saldo * 0.01;
        }

        public override void CalcularTaxaManutencao()
        {
            Saldo -= 12;
        }
    }
}
