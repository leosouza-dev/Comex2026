
namespace testeAula.Models
{
    public class GerenciadorDeImpostos
    {
        public double TotalDeImposto { get; private set; }

        public void Registrar(ITributavel item)
        {
            TotalDeImposto += item.CalcularImposto();
        }
    }
}
