class TabelaAleatoria
{
    static void Main()
    {
        System.Random gerador = new System.Random();
        int[][] array = new int[3][];
        for (int a = 0; a < array.Length; a++)
        {
            array[a] = new int[3];
            for (int b = 0; b < array.Length; b++)
            {
                array[a][b] = (int)(gerador.NextDouble() * 100);
            }
        }
        for(int a=0;a<array.Length;a++){
            for(int b=0;b<array.Length;b++){
                System.Console.WriteLine(array[a][b]);
            }
        }
    }
}