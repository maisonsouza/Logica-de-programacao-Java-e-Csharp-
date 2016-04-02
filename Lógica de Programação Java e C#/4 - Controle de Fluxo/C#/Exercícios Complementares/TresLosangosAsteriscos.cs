class TresLosangosAsteriscos
{
    static void Main()
    {
        for (int quantidadedelosangos = 1; quantidadedelosangos <= 3; quantidadedelosangos++)
        {
            for (int escreveasteriscos = 1; escreveasteriscos <= 5; escreveasteriscos++)
            {
                System.Console.WriteLine("**********");
                
                for (int escreveespaco = 0; escreveespaco < escreveasteriscos; escreveespaco++)
                {
                    if (escreveasteriscos >= 5)
                    {
                        break;
                    }
                    System.Console.Write(" ");
                }
            }
        }
    }
}