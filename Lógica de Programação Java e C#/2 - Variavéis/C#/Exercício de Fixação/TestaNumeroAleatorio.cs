class TestaNumeroAleatorio
{
    static void Main()
    {
        double numeroAleatorio ;
		System.Random gerador = new System.Random();
        numeroAleatorio = gerador.NextDouble() * 100;
        System.Console.WriteLine(numeroAleatorio);
    }
}