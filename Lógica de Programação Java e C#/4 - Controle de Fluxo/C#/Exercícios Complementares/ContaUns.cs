class ContaUns
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        double valor1 = gerador.NextDouble();
        System.Console.WriteLine(valor1);
        string numero = "" + valor1;
        int resposta = 0;
        for (int i = 0; i < numero.Length; i++)
        {
            if (numero[i] == '1')
            {
                resposta++;
            }
        }
        System.Console.WriteLine("Número de Ocorrências " + resposta);
    }
}