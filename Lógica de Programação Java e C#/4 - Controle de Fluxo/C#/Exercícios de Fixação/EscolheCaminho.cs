class EscolheCaminho
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        double valor = gerador.NextDouble();
        System.Console.WriteLine(valor);
        if (valor < 0.5)
        {
            System.Console.WriteLine("Vire a Esquerda");
            valor = gerador.NextDouble();
            System.Console.WriteLine(valor);
            if (valor < 0.5)
            {
                System.Console.WriteLine("Vire a Esquerda");
            }
            else
            {
                System.Console.WriteLine("Vire a Direita");
            }
        }
        else
        {
            System.Console.WriteLine("Vire a direita");
            valor = gerador.NextDouble();
            System.Console.WriteLine(valor);
            if (valor < 0.5)
            {
                System.Console.WriteLine("Vire a Esquerda");
            }
            else
            {
                System.Console.WriteLine("Vire a Direita");
            }
        }
    }
}