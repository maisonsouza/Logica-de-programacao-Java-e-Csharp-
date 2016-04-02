class GeradorDeIngressos
{
    static void Main()
    {
        for (int s = 1; s <= 4; s++)
        {
            for (int c = 1; c <= 20; c++)
            {
                System.Console.WriteLine("Setor = "+s+" Cadeira = "+c);
            }
        }
    }
}