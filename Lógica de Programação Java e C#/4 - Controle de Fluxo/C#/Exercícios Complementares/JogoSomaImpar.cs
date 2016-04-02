class JogoSomaImpar
{
    static void Main()
    {
        int soma = 0, cont = 0;
        System.Random gerador = new System.Random();
        for (int a = 1; a <= 10; a++)
        {
            int valor = (int) (gerador.NextDouble() * 6 + 1);
            System.Console.WriteLine(valor);
            if (valor == 6)
            {
                cont++;
                if (cont >= 2)
                {
                    System.Console.WriteLine("Você já perdeu o número 6 apareceu duas vezes");
                    break;
                }
            }
            soma += valor;
        }
        if (soma % 2 != 0 && cont<2)
        {
            System.Console.WriteLine("Você ganhou!! a soma é ímpar = "+soma);
        }
        if(soma % 2 == 0 && cont<2)
        {
            System.Console.WriteLine("Você perdeu!! A soma é par "+soma);
        }
            
    }
}