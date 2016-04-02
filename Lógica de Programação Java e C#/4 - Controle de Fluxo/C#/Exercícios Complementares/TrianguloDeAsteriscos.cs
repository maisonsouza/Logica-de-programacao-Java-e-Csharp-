class TrianguloDeAsteriscos
{
    static void Main()
    {
        for (int quantidadedetriangulos = 1; quantidadedetriangulos <= 3; quantidadedetriangulos++)
        {
            for (int pulalinha = 1; pulalinha <= 6; pulalinha++)
            {
                System.Console.WriteLine();
                for (int escreve = 1; escreve <= pulalinha; escreve++)
                {
                    System.Console.Write("*");
                }
            }
        }
    }
}