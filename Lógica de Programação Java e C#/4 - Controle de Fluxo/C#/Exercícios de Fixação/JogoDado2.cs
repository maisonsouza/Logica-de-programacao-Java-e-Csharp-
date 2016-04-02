class JogoDado2
{
    static void Main()
    {
        int soma = 0;
        for (int j = 1; j <= 4; j++)
        {
            System.Random gerador = new System.Random();
            int numero = (int)(gerador.NextDouble() * 6 + 1);
            System.Console.WriteLine(numero);
            if (numero % 2 != 0)
            {
                soma += numero;
                if (soma > 9)
                {
                    System.Console.WriteLine("Parabéns vc ganhou com = "+j+" Lançamentos Total de Pontos = "+soma);
                    break;
                }
            }
        }
    }
}