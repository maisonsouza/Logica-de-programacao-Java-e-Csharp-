class SequenciaCrescente
{
    static void Main()
    {
        int[] vetor = new int[10];
        for (int a = 0; a < vetor.Length; a++)
        {
            vetor[a] = a + 1;
            System.Console.WriteLine(vetor[a]);
        }
    }
}