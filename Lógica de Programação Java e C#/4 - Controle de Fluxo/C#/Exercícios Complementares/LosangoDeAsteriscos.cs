class LosangoDeAsteriscos
{
    static void Main()
    {
            for (int escreveasteriscos = 1; escreveasteriscos <= 5; escreveasteriscos++)
            {
                System.Console.WriteLine("**********");
                for (int escreveespaco = 1; escreveespaco <= escreveasteriscos; escreveespaco++)
                {
                    System.Console.Write(" ");
                }
            }
    }
}