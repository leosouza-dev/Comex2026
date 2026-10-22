namespace testeAula.Models
{
    public class SeguroDeVida : ITributavel
    {
        public double ValorPremio { get; set; }

        public double CalcularImposto()
        {
            return 50 + (ValorPremio * 0.01);
        }
    }
}
