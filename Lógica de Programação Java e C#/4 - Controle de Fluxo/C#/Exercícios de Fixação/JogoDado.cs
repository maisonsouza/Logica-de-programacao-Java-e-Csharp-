class JogoDado
{
    static void Main()
    {
        int soma = 0;
        for (int i = 1; i <= 5; i++)
        {
            System.Random gerador = new System.Random();
            int numero = (int)(gerador.NextDouble() * 6 + 1);
            System.Console.WriteLine(numero);
            soma += numero;
            if (soma > 19)
            {
                System.Console.WriteLine("Parabéns você ganhou com " + i + " jogadas. Total de pontos = " + soma);
                break;
            }
        }
    }
}