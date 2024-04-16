public class Estudante
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Matricula { get; set; }
    public string Curso { get; set; }
    public List<double> Nota { get; set; }

    public Estudante(string nome, DateTime dataNascimento, string matricula, string curso)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Matricula = matricula;
        Curso = curso;
        Nota = new List<double>();
    }

    public double CalcularMedia()
    {
        double soma = 0;

        for (int i = 0; i < Nota.Count; i++)
        {
            soma += Nota[i];
        }
        
        return soma / Nota.Count;
    }

}