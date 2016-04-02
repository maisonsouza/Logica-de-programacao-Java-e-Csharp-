class ComparaValores
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        double valor1 = gerador.NextDouble();
        double valor2 = gerador.NextDouble();
        System.Console.WriteLine(valor1);
        System.Console.WriteLine(valor2);
        if (valor1 > valor2)
        {
            System.Console.WriteLine("Primeiro > Segundo");
        }
        if (valor1 < valor2)
        {
            System.Console.WriteLine("Segundo > Primeiro");
        }
        else if (valor1 == valor2)
        {
            System.Console.WriteLine("Primeiro== Segundo");
        }
           
        }
}