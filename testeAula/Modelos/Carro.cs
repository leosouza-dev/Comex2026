namespace GestaoFrota.Modelos
{
    internal class Carro : Veiculo
    {
        public static int TotalCarros { get; private set; }

        public string Placa { get; set; }
        public string Modelo { get; set; }

        public Carro(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
            TotalCarros++;
        }
    }
}
