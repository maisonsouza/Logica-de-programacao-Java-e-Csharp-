class AprovadoReprovado
{
    static void Main()
    {
        System.Random geradordenota = new System.Random();
        double nota = geradordenota.NextDouble()*10;
        if (nota > 6)
            System.Console.WriteLine(nota+" Aprovado");
        else
            System.Console.WriteLine(nota+ " Reprovado");
    }
}