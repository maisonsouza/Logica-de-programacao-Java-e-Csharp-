class TestaFormatacao
{
    static void Main()
    {
        string nome = "Maison Marcel Madri";
        int idade = 27;
        double peso = 86.253;
        System.Console.WriteLine("O {0} tem {1} anos e pesa {2:F2}", nome, idade, peso);
    }
}