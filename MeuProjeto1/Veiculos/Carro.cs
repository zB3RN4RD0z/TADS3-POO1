public class Carro : Veiculo
{
    public int NumeroPortas { get; set; }
    public double PrecoTabela { get; set; }
 
    public Carro(string marca, string modelo, int ano, int numeroPortas, double precoTabela) : base(marca, modelo, ano)
    {
        NumeroPortas = numeroPortas;
        PrecoTabela = precoTabela;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Numero de Portas: {NumeroPortas}");
    }
    
    public override void CalcularImposto()
    {
        double taxaImposto = 0.1;
        double imposto = PrecoTabela * taxaImposto;
        
        Console.WriteLine($"Imposto calculado para carro: R$ {imposto}");
    }
}