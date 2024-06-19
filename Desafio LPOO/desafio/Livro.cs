public class Livro
{
    public string Titulo { get; private set; }
    public Autor Autor { get; private set; }
    public double? Preco { get; private set; }

    public Livro(string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public Livro(string titulo, Autor autor, double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Título: {Titulo}");
        Autor.MostrarInfo();
        if (Preco.HasValue)
        {
            Console.WriteLine($"Preço: R${Preco.Value:F2}");
        }
        else
        {
            Console.WriteLine("Preço: Indisponível");
        }
    }

    public void AplicarDesconto(double porcentagem)
    {
        if (Preco.HasValue)
        {
            Preco -= Preco.Value * porcentagem;
            if (Preco < 0) Preco = 0;
        }
        else
        {
            Console.WriteLine("Preço não disponível para aplicar desconto.");
        }
    }

    public void AplicarDesconto(int valorFixo)
    {
        if (Preco.HasValue)
        {
            Preco -= valorFixo;
            if (Preco < 0) Preco = 0;
        }
        else
        {
            Console.WriteLine("Preço não disponível para aplicar desconto.");
        }
    }
}