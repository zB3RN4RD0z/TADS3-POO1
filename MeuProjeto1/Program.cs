class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro("Toyota", "Corolla", 2020, 4, 50000);
        Moto moto = new Moto("Honda", "CB 500", 2019, "Esportiva", 20000);
        Caminhao caminhao = new Caminhao("Volvo", "FH", 2018, 20, 150000);

        Console.WriteLine("Informacoes do Carro: ");
        carro.ExibirInformacoes();
        carro.CalcularImposto();

        Console.WriteLine("\nInformacoes da Moto: ");
        moto.ExibirInformacoes();
        moto.CalcularImposto();

        Console.WriteLine("\nInformacoes do Caminhao: ");
        caminhao.ExibirInformacoes();
        caminhao.CalcularImposto();
    }
}