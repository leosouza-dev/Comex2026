namespace testeAula.Models
{
    public abstract class Conta
    {
        public static int TotalDeContas { get; set; }

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Conta(string titular, double saldo)
        {
            TotalDeContas++;

            Titular = titular;
            Saldo = saldo;
            Numero = TotalDeContas;
        }

        public virtual void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        // Toda classe filha é obrigada a implementar esse método
        public abstract void CalcularTaxaManutencao();
    }
}
