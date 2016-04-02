class CartoesDeEstacionamento
{
    static void Main()
    {
        for (int blocos = 1; blocos <= 3; blocos++)
        {
            for (int andares = 1; andares <= 9; andares++)
            {
                for (int apartamentos = 1; apartamentos <= 4; apartamentos++)
                {
                    System.Console.WriteLine("Bloco " + blocos + " Andar " + andares + " Apartamento " + apartamentos);
                }
            }
        }
    }
}