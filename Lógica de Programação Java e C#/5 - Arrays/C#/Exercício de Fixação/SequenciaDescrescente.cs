class SequenciaDecrescente
{
    static void Main()
    {
        int [] vetor = new int [10];
        for (int a = 0; a < vetor.Length; a++)
        {
            vetor[a] = vetor.Length - a;
            System.Console.WriteLine(vetor[a]);
        }

    }
}