class VerificaValorproduto
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        double preco1 = gerador.NextDouble()*1000;
        System.Console.WriteLine("Produto 1 = " + preco1);
        double preco2 = gerador.NextDouble()*1000;
        System.Console.WriteLine("Produto 2 = "+preco2);

        if (preco1 > preco2)
        {
            System.Console.WriteLine("O produto 2 é mais barato");
        }
        else if (preco2 > preco1)
        {
            System.Console.WriteLine("O produto 1 é mais barato");
        }
        else {
            System.Console.WriteLine("Os preços são iguais");
        }
            
    }
}