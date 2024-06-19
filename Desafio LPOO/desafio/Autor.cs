public class Autor
{
    public string Nome { get; private set; }
    public string Nacionalidade { get; private set; }

    public Autor(string nome, string nacionalidade)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Autor: {Nome}");
        Console.WriteLine($"Nacionalidade: {Nacionalidade}");
    }
}