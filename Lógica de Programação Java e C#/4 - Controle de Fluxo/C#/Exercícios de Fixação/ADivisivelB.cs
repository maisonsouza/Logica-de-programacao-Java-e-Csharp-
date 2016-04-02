class ADivisivelB
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        int valor1 = (int)(gerador.NextDouble()*1000);
        int valor2 = (int)(gerador.NextDouble()*20);
        System.Console.WriteLine("valor 1"+valor1);
        System.Console.WriteLine("valor 2"+valor2);
        if (valor1 % valor2 == 0)
        {
            System.Console.WriteLine("É divisível");
        }
        else
        {
            System.Console.WriteLine("Não é Dívisivel");
        }
    }
}