namespace testeAula.Models
{
    public class ContaInvestimento : Conta
    {
        public ContaInvestimento(string titular, double saldo) : base(titular, saldo)
        {
        }

        public override void CalcularTaxaManutencao()
        {
            Saldo -= 15;
        }

        public override void Sacar(double valor)
        {
            double taxa = 5;
            base.Sacar(valor + taxa);
        }

        // metodo espe
    }
}
