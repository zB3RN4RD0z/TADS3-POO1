public class Moto : Veiculo
{
    public string Tipo { get; set; }
    public double PrecoTabela { get; set; }

    public Moto(string marca, string modelo, int ano, string tipo, double precoTabela) : base(marca, modelo, ano)
    {
        Tipo = tipo;
        PrecoTabela = precoTabela;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Tipo: {Tipo}");
    }

    public override void CalcularImposto()
    {
        double taxaImposto = 0.05;
        double imposto = PrecoTabela * taxaImposto;

        Console.WriteLine($"Imposto calculado para moto: R$ {imposto}");
    }
}