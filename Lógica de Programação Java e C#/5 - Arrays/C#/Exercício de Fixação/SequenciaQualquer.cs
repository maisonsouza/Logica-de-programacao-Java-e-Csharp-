class SequenciaQualquer
{
    static void Main()
    {
        int[] vetor = new int[10];
        vetor[0] = 15;
        vetor[1] = 15;
        vetor[2] = 12;
        vetor[3] = 15;
        vetor[4] = 15;
        vetor[5] = 12;
        vetor[6] = 15;
        vetor[7] = 15;
        vetor[8] = 12;
        vetor[9] = 15;
        for (int a = 0; a < vetor.Length; a++)
        {
            System.Console.WriteLine(vetor[a]);
        }

    }
}