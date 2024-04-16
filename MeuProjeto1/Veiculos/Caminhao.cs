public class Caminhao : Veiculo
{
    public int CapacidadeCarga { get; set; }
    public double PrecoTabela { get; set; }

    public Caminhao(string marca, string modelo, int ano, int capacidadeCarga, double precoTabela) : base(marca, modelo, ano)
    {
        CapacidadeCarga = capacidadeCarga;
        PrecoTabela = precoTabela;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} toneladas");
    }

    public override void CalcularImposto()
    {
        double taxaImposto = 0.15;
        double imposto = PrecoTabela * taxaImposto;
        Console.WriteLine($"Imposto calculado para caminhao: R$ {imposto}");

    }
}