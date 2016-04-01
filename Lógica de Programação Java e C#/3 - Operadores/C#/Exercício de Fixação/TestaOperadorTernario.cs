class TestaOperadorTernario
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        int media = (int)(gerador.NextDouble()*10);
        System.Console.WriteLine(media);
        System.Console.WriteLine(media>5? "Aprovado" :"Reprovado");
    }
}