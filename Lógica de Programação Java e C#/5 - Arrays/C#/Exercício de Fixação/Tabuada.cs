class Tabuada
{
    static void Main()
    {
        int[][] tabuada = new int[10][];
        for (int a=0; a < tabuada.Length; a++)
        {
            tabuada[a] = new int [10];
            for (int b = 0; b < tabuada[a].Length; b++)
            {
                tabuada[a][b] = (a + 1) * (b + 1);
            }
        }
        for (int a = 0; a < tabuada.Length; a++)
        {
            System.Console.WriteLine("");
            for (int b = 0; b < tabuada[a].Length; b++)
            {
                System.Console.WriteLine((a + 1) + " * " + (b + 1) + " = " + tabuada[a][b]);
            }
        }
    }
}