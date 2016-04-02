class SequenciaAleatoria
{
    static void Main()
    {
        int[] vetor = new int[10];
        System.Random gerador = new System.Random();
        for (int a = 0; a < vetor.Length; a++)
        {
            vetor[a] = (int)(gerador.NextDouble()*10);
            System.Console.WriteLine(vetor[a]);
        }
    }
}