class EscolheRoupa
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        double valor = gerador.NextDouble();
        if (valor < 0.5)
        {
            System.Console.WriteLine("Camiseta Preta");
        }
        else
        {
            System.Console.WriteLine("Camiseta Vermelha");
        }
        valor = gerador.NextDouble();
        if (valor < 0.5)
        {
            System.Console.WriteLine("Cal�a jeans");
        }
        else
        {
            System.Console.WriteLine("Bermuda");
        }
        if (valor < 0.5)
        {
            System.Console.WriteLine("T�nis");
        }
        else
        {
            System.Console.WriteLine("Sapato");
        }
        if (valor < 0.5)
        {
            System.Console.WriteLine("Bon�");
        }
        else
        {
            System.Console.WriteLine("�culos");
        }
    }
}