class ConsumoDeCombustivel
{
    static void Main()
    {
        double resposta1 = calculaConsumoLitroKilometro(130.25, 15);
        double resposta2 = calculaConsumoLitroKilometro(133.25, 8);
        System.Console.WriteLine(resposta1);
        System.Console.WriteLine(resposta2);
    }
       static double calculaConsumoLitroKilometro(double quilometro, int litros)
    {
        double consumo = (quilometro / litros);
        return consumo;
    }   
}