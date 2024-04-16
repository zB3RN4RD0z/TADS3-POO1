namespace MeuProjeto2;

class Program
{
    static List<Estudante> estudantes = new List<Estudante>();
    static void Main(string[] args)
    {
        while (true)
        {
            MostrarMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarEstudante();
                    break;
                case "2":
                    AdicionarNota();
                    break;
                case "3":
                    ExibirMedias();
                    break;
                case "4":
                    ListarEstudantes();
                    break;
                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opcao invalida. Por favor, escolha uma opcao valida");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1 - Adicionar Estudante");
        Console.WriteLine("2 - Adicionar Nota");
        Console.WriteLine("3 - Exibir Medias");
        Console.WriteLine("4 - Listar Estudantes");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("Escolha uma opcao: ");
    }

    static void AdicionarEstudante()
    {
        Console.WriteLine("Digite o nome do estudante: ");
        string nome = Console.ReadLine();
    }

    /*

        O PROGRAMA EM SI NÃO ESTÁ FINALIZADO TOTALMENTE, E SEM FUNCIONAMENTO, É CLARO. PORTANTO, ATÉ AQUI
        EU NÃO TIVE CRIATIVIDADE PARA DAR CONTINUIDA AO CÓDIGO E ALGUMAS DIFICULDADES E DÚVIDAS SURGIRAM
        DURANTE A IMPLEMENTAÇÃO DA ATIVIDADE.

    */

    /*

        O Program.cs ESTÁ COM ERRO PORQUE NÃO FOI FINALIZADO A IMPLEMENTAÇÃO DELE, MAS DEIXO ESSE CÓDIGO
        ATÉ ONDE EU SEI

    */
}