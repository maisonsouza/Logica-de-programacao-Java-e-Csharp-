class TabelaQualquer
{
    static void Main()
    {
        int[][] matriz = new int [3][];
        for (int a = 0; a < matriz.Length; a++)
        {
            matriz[a] = new int[3];
        }
        matriz[0][0] = 12;
        matriz[0][1]=15;
        matriz[0][2]=18;
        matriz[1][0]=21;
        matriz[1][1]=25;
        matriz[1][2]=31;
        matriz[2][0]=43;
        matriz[2][1]=56;
        matriz[2][2]=78;
        for(int a=0;a<matriz.Length;a++){
            for(int b=0;b<matriz[a].Length;b++){
                System.Console.WriteLine(matriz[a][b]);
            }
        }
    }
}