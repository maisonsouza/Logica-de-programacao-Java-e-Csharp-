class Imprime100ExcetoMultiplo3
{
    static void Main()
    {
        for (int a = 1; a <= 100; a++)
        {
            if (a % 3 != 0)
            {
                System.Console.WriteLine(a);
            }
                
        }
    }
}