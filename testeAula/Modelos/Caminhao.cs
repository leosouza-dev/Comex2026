using GestaoFrota.Interfaces;

namespace GestaoFrota.Modelos
{
    internal class Caminhao : Veiculo, IRastreavel
    {
        public int Eixos { get; set; }
        public override double CalcularAluguel(int dias)
        {
            //return base.CalcularAluguel(dias * Eixos);
            return (dias * ValorDiaria) + (Eixos * 50);
        }

        public string ObterLocalizacao()
        {
            return "Latitude: -23.5, Longitude: -46.6";
        }
    }
}
