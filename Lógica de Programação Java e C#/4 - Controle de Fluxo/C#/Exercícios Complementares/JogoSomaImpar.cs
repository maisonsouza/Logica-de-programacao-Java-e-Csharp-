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
                    System.Console.WriteLine("Voc� j� perdeu o n�mero 6 apareceu duas vezes");
                    break;
                }
            }
            soma += valor;
        }
        if (soma % 2 != 0 && cont<2)
        {
            System.Console.WriteLine("Voc� ganhou!! a soma � �mpar = "+soma);
        }
        if(soma % 2 == 0 && cont<2)
        {
            System.Console.WriteLine("Voc� perdeu!! A soma � par "+soma);
        }
            
    }
}