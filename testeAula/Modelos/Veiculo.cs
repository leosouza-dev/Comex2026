namespace GestaoFrota.Modelos
{
    internal class Veiculo
    {
        public double ValorDiaria { get; set; }

        public virtual double CalcularAluguel(int dias)
        {
            return dias * ValorDiaria;
        }
    }
}
