public class Program
{
    public static void Main(string[] args)
    {
        Autor autor = new Autor("Machado de Assis", "Brasileiro");
        Livro livro1 = new Livro("Dom Casmurro", autor, 50.0);
        Livro livro2 = new Livro("Memórias Póstumas de Brás Cubas", autor, 35.0);

        Console.WriteLine("Informações do Livro 1:");
        livro1.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Informações do Livro 2:");
        livro2.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Aplicando desconto percentual de 20% no livro1:");
        livro1.AplicarDesconto(0.20);
        livro1.MostrarInfo();
        Console.WriteLine();

        Console.WriteLine("Aplicando desconto fixo de R$10,00 no livro1:");
        livro1.AplicarDesconto(10);
        livro1.MostrarInfo();
    }
}